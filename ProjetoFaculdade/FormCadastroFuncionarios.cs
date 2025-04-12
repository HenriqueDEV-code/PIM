using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CEP
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;  // Não pode esquecer de instalar o pacote dele via NuGet
using System.Web.UI.Design.WebControls.WebParts;
using System.Windows.Forms;


namespace ProjetoFaculdade
{
    public partial class FormCadastroFuncionarios : Form
    {
        public FormCadastroFuncionarios()
        {
            InitializeComponent();
        }



        #region TRATAMENTO DE ENTRADA DE DADOS EVENTO KEYPRESS
        private void tB_NomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Permite a entrada
            }
        }

        private void tB_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Permite a entrada
            }
        }


        #endregion




        #region TRATAMENTO DE DADOS NULOS

        private void tB_NomeCompleto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_NomeCompleto.Text))
            {
                MessageBox.Show("Valor inválido. Campo não pode estar vazio!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_NomeCompleto.Focus();
            }

        }

        private void tB_Email_Leave(object sender, EventArgs e)
        {
            string[] dominiosPermitidos =
            {
                "@gmail.com", "@outlook.com", "@protonmail.com", "@zoho.com",
                "@yahoo.com", "@icloud.com", "@gmx.com", "@aol.com",
                "@fastmail.com", "@tutanota.com", "@gmail.com.br", "@outlook.com.br",
                "@protonmail.com.br", "@zoho.com.br", "@yahoo.com.br", "@icloud.com.br",
                "@gmx.com.br", "@aol.com.br", "@fastmail.com.br", "@tutanota.com.br",
                "@hotmail.com"
            };

            string email = tB_Email.Text.Trim();

            // Aqui vamos verificar se o e-mail tem um formato mínimo válido

            if (!email.Contains("@") || email.Split('@').Length != 2)
            {
                MessageBox.Show("E-mail inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Email.Focus();
                return;
            }

            // Obtem o dominio digitado pelo usuario
            string dominio = "@" + email.Split('@')[1];

            // Verifica se o dominio esta na lista permitida
            bool dominioValido = Array.Exists(dominiosPermitidos, d => d.Equals(dominio, StringComparison.OrdinalIgnoreCase));

            if (!dominioValido)
            {
                MessageBox.Show("Dominio de E-mail inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Email.Focus();
            }
        }

        private void MtB_Nascimento_Leave(object sender, EventArgs e)
        {
            // vamos verificar se o campo esta vazio
            if (string.IsNullOrWhiteSpace(MtB_Nascimento.Text))
            {
                return; // sai da funcao sem calcular nada
            }

            if (DateTime.TryParseExact(MtB_Nascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                // Calcular a idade
                int idade = Calc_Idade(dataNascimento);

                // Validação da idade permitida
                if (idade <= 16 )
                {
                    MessageBox.Show("Idade não permitida, funcionário parece ser menor de idade! ",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Nascimento.Clear();
                    MtB_Nascimento.Focus();
                } else if (idade >= 16 && idade < 18 || idade >= 60 && idade <= 80)
                {
                    MessageBox.Show("Idade não parece permitida! Gostaria de inserir mesmo assim? ", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    return;
                }else if (idade >= 81)
                {
                    MessageBox.Show("Idade não permitida, funcionário parece que já aposentou! ",
                     "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Nascimento.Clear();
                    MtB_Nascimento.Focus();
                }

            }
            else
            {
                MessageBox.Show("Data inválida! Informe no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtB_Nascimento.Clear();
                MtB_Nascimento.Focus();
            }

        }

        // Calcular idade
        private int Calc_Idade(DateTime DataNascimeto)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimeto.Year;

            // Ajustar se ainda nao fez Aniverario este ano
            if(DataNascimeto.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }


        private void MtB_CPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(MtB_CPF.Text.Where(char.IsDigit).ToArray()); // Remove tudo exceto números

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Valor inválido. O campo não pode estar vazio!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtB_CPF.Focus();
                return;
            }

            if (!ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido! Digite um CPF válido.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                MtB_CPF.Focus();
            }


        }


        // Metodo para validar CPF
        private bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false; // Verifica se tem 11 dígitos e não são todos iguais

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            tempCpf += primeiroDigito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith($"{primeiroDigito}{segundoDigito}");

        }


        private void MtB_Cep_Leave(object sender, EventArgs e)
        {
            string cep = MtB_Cep.Text;
            // Remover espaços e caracteres desnecessários
            cep = cep.Trim().Replace(" ", "").Replace("-", "");

            if (string.IsNullOrWhiteSpace(cep))
            {
                MessageBox.Show("Valor inválido. Campo não pode estar vazio!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtB_Cep.Focus();
            }
        }


        private async void MBNT_Pesquisa_CEP_Click(object sender, EventArgs e)
        {
            // Obtem o valor digitado
            string cep = MtB_Cep.Text;

            // Remover espaços e caracteres desnecessários
            cep = cep.Trim().Replace(" ", "").Replace("-", "");

            try
            {
                // Validação básica do CEP (8 dígitos numéricos)
                if (cep.Length != 8 || !Regex.IsMatch(cep, @"^\d{8}$"))
                {
                    MessageBox.Show("CEP inválido. Certifique-se de que contém exatamente 8 dígitos numéricos.",
                        "Erro no CEP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // URL da API ViaCEP
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                using (HttpClient client = new HttpClient())
                {
                    // Enviar requisição e obter resposta
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Ler o JSON retornado
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Verifica se a API retornou algum erro
                    if (jsonResponse.Contains("\"erro\""))
                    {
                        MessageBox.Show("CEP não encontrado. Verifique o número informado.",
                            "Erro no CEP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Parse do JSON usando NewtonSoft.Json
                    JObject json = JObject.Parse(jsonResponse);

                    string logradouro = json["logradouro"]?.ToString() ?? "Informação não disponível";
                    string bairro = json["bairro"]?.ToString() ?? "Informação não disponível";
                    string localidade = json["localidade"]?.ToString() ?? "Informação não disponível";
                    string uf = json["uf"]?.ToString() ?? "Informação não disponível";

                    // Preencher os dados do CEP
                    tB_Logradouro.Text = logradouro;
                    tB_Bairro.Text = bairro;
                    tB_Cidade.Text = localidade;
                    tB_UF.Text = uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o endereço via CEP: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tB_Cargo_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tB_Cargo.Text))
            {
                MessageBox.Show("Valor inválido. Campo não pode estar vazio!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Cargo.Focus();
            }

        }

        // Funcao para validar se tem numeros seguenciais repitidos minimo 6 digitos
        private bool Digito(string telefone)
        {
            int contador = 1;

            for (int i = 1; i < telefone.Length; i++)
            {
                if (telefone[i] == telefone[i - 1])
                {
                    contador++;
                    if (contador >= 6)
                        return true;
                }
                else
                {
                    contador = 1;
                }
            }
            return false;
        }

        private void MtB_Telefone_Leave(object sender, EventArgs e)
        {
            string Telefone = new string(MtB_Telefone.Text.Where(char.IsDigit).ToArray()); // Remove tudo exceto números

            if (string.IsNullOrWhiteSpace(Telefone))
            {
                MessageBox.Show("Valor inválido. Campo não pode estar vazio!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtB_Telefone.Focus();
                return;
            }

            // validar repetiçoes

            if (Digito(Telefone))
            {
                MessageBox.Show("Telefone inválido. Número repetitivo detectado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtB_Telefone.Clear();
                MtB_Telefone.Focus();
                return;
            }


        }


        private void MtB_Admissao_Leave(object sender, EventArgs e)
        {

            // vamos verificar se o campo esta vazio
            if (string.IsNullOrWhiteSpace(MtB_Nascimento.Text))
            {
                return;
            }

            // Campo para converte o texto para uma data

            if (DateTime.TryParse(MtB_Admissao.Text, out DateTime dataAdmissao))
            {
                DateTime hoje = DateTime.Today;
                DateTime limiteMaximo = hoje.AddMonths(1);

                // verificar se a data utrapassa o limite
                if (dataAdmissao > limiteMaximo)
                {
                    MessageBox.Show("Data de admissão inválida. Não pode ultrapassar 30 dias a partir de hoje!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Admissao.Focus();
                    return;
                }

                // Segundo: não pode ser de mês anterior ao atual
                if (dataAdmissao.Month < hoje.Month || dataAdmissao.Year < hoje.Year)
                {
                    MessageBox.Show("Data de admissão inválida. Não pode ser de mês anterior ao atual!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Admissao.Focus();
                    return;
                }

            }
            else
            {
                // Se não conseguir converter, mostra erro
                MessageBox.Show("Data inválida. Por favor, insira uma data válida!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                MtB_Admissao.Focus();
            }


        }

        private void tB_Salario_TextChanged(object sender, EventArgs e)
        {

            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
                return;

            // Remove tudo que não é número
            string valor = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(valor))
                valor = "0";

            // Converte para decimal e divide por 100 para colocar as casas decimais
            decimal valorDecimal = decimal.Parse(valor) / 100;

            // Atualiza o texto formatado
            txt.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorDecimal);

            // Move o cursor para o final
            txt.SelectionStart = txt.Text.Length;
        }



        #endregion




        #region Buttons de funcionalidade

        private string GerarMatricula()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";

            StringBuilder matricula = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    matricula.Append(letras[random.Next(0, letras.Length)]);
                }
                else
                {
                    matricula.Append(numeros[random.Next(0, numeros.Length)]);
                }
            }
            return matricula.ToString();
        }


        private void MBNT_Limpar_Click(object sender, EventArgs e)
        {
            tB_NomeCompleto.Clear();
            tB_Email.Clear();
            MtB_Telefone.Clear();
            MtB_CPF.Clear();
            MtB_Nascimento.Clear();
            MtB_Cep.Clear();
            tB_Logradouro.Clear();
            tB_Bairro.Clear();
            tB_Cidade.Clear();
            tB_UF.Clear();
            tB_Cargo.Clear();
            MtB_Admissao.Clear();
            tB_Salario.Clear();
            tB_id_Matricula.Clear();

            tB_id_Matricula.Focus();

            tB_id_Matricula.Text = GerarMatricula();



        }


        private void MBNT_Localizar_Click(object sender, EventArgs e)
        {
            Localizar localizar = new Localizar();
            localizar.ShowDialog();
            this.Show();
        }

        #endregion


    }
}
