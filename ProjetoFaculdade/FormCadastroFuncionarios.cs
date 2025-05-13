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
using Npgsql;



namespace ProjetoFaculdade
{
    public partial class FormCadastroFuncionarios : Form
    {
        public FormCadastroFuncionarios()
        {
            InitializeComponent();

            DefinirEnabledNosCampos(this, false);
        }

        #region boqueio e Desbloqueio de TextoBox

        private void DefinirEnabledNosCampos(Control parent, bool enabled)
        {
            foreach (Control controle in parent.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Enabled = enabled;
                }
                else if (controle is MaskedTextBox)
                {
                    ((MaskedTextBox)controle).Enabled = enabled;
                }
                else if (controle.HasChildren)
                {
                    // Se for GroupBox, Panel, etc, entra neles também
                    DefinirEnabledNosCampos(controle, enabled);
                }
            }
        }



        #endregion


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

        private void tB_Busca_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Permite a entrada
            }
        }


        #endregion


        #region TRATAMENTO DE DADOS NULOS


        private void MtB_Clien_Edit_Leave(object sender, EventArgs e)
        {
            string texto = MtB_Clien_Edit.Text.Trim();

            if (texto.Equals("Cliente", StringComparison.OrdinalIgnoreCase))
            {
                Grupo_Dados_Contrato.Visible = false;
            }
            else
            {
                Grupo_Dados_Contrato.Visible = true;
            }

        }


        private void tB_NomeCompleto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_NomeCompleto.Text))
            {
                errorProvider1.SetError(tB_NomeCompleto, "O campo NOME é obrigatório.");
            }
            else
            {
                errorProvider1.SetError(tB_NomeCompleto, "");
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
                errorProvider1.SetError(tB_Email, "Email Invalido");
                tB_Email.Clear();
                return;
            }
            else
            {
                errorProvider1.SetError(tB_Email, "");
            }

            // Obtem o dominio digitado pelo usuario
            string dominio = "@" + email.Split('@')[1];

            // Verifica se o dominio esta na lista permitida
            bool dominioValido = Array.Exists(dominiosPermitidos, d => d.Equals(dominio, StringComparison.OrdinalIgnoreCase));

            if (!dominioValido)
            {
                errorProvider1.SetError(tB_Email, "Dominio {@} inválido");
                return;
            }
            else
            {
                errorProvider1.SetError(tB_Email, "");
            }
        }

        private void MtB_Nascimento_Leave(object sender, EventArgs e)
        {


            if (DateTime.TryParseExact(MtB_Nascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                // Calcular a idade
                int idade = Calc_Idade(dataNascimento);

                // Validação da idade permitida
                if (idade <= 16)
                {
                    MessageBox.Show("Idade não permitida, funcionário parece ser menor de idade! ",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Nascimento.Clear();
                    MtB_Nascimento.Focus();
                }
                else if (idade >= 16 && idade < 18 || idade >= 60 && idade <= 80)
                {
                    MessageBox.Show("Idade não parece permitida! Gostaria de inserir mesmo assim? ", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    return;
                }
                else if (idade >= 81)
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

            }

        }

        // Calcular idade
        private int Calc_Idade(DateTime DataNascimeto)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimeto.Year;

            // Ajustar se ainda nao fez Aniverario este ano
            if (DataNascimeto.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }


        private void MtB_CPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(MtB_CPF.Text.Where(char.IsDigit).ToArray()); // Remove tudo exceto números



            if (!ValidarCPF(cpf))
            {
                errorProvider1.SetError(MtB_CPF, "CPF inválido! Digite um válido");
                MtB_CPF.Clear();
            }
            else
            {
                errorProvider1.SetError(MtB_CPF, "");
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
            string cep = MtB_Cep.Text.Trim().Replace(" ", "").Replace("-", "");
            MtB_Cep.Text = cep; // Atualiza o texto no campo, se desejar
            MBNT_Pesquisa_CEP_Click(sender, e);

        }

        private string LimparCep(string cep)
        {
            return cep.Trim().Replace(" ", "").Replace("-", "");
        }


        private async void MBNT_Pesquisa_CEP_Click(object sender, EventArgs e)
        {
            // Obtem o valor digitado
            string cep = MtB_Cep.Text;

            cep = LimparCep(cep);

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

            if (MtB_Clien_Edit.Checked) // Se for cliente
            {
                tB_Cargo.Enabled = false;
                errorProvider1.SetError(tB_Cargo, ""); // Sem erro, não é necessário cargo

            }

            else // Não é cliente
            {
                tB_Cargo.Enabled = true;

                if (string.IsNullOrWhiteSpace(tB_Cargo.Text))
                {
                    errorProvider1.SetError(tB_Cargo, "O campo CARGO é obrigatório.");
                }
                else
                {
                    errorProvider1.SetError(tB_Cargo, "");
                }
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
            string telefone = new string(MtB_Telefone.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(telefone))
            {
                errorProvider1.SetError(MtB_Telefone, "O campo TELEFONE é obrigatório.");
                return;
            }
            else
            {
                errorProvider1.SetError(MtB_Telefone, "");
            }

            if (Digito(telefone))
            {
                errorProvider1.SetError(MtB_Telefone, "Telefone inválido. Número repetitivo detectado.");
                return;
            }
            else
            {
                errorProvider1.SetError(MtB_Telefone, "");
            }
        }


        private void MtB_Admissao_Leave(object sender, EventArgs e)
        {

            // Tenta converter o texto para uma data
            if (DateTime.TryParse(MtB_Admissao.Text, out DateTime dataAdmissao))
            {

                DateTime hoje = DateTime.Today;
                DateTime limiteMaximo = hoje.AddDays(30); // Mais preciso que AddMonths(1)

                // Verifica se a data ultrapassa o limite de 30 dias
                if (dataAdmissao > limiteMaximo)
                {
                    MessageBox.Show("Data de admissão inválida. Não pode ultrapassar 30 dias a partir de hoje!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Admissao.Focus();
                    return;
                }

                // Verifica se a data é de mês anterior ao atual (considerando o ano)
                if (dataAdmissao.Year < hoje.Year ||
                    (dataAdmissao.Year == hoje.Year && dataAdmissao.Month < hoje.Month))
                {
                    MessageBox.Show("Data de admissão inválida. Não pode ser de mês anterior ao atual!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MtB_Admissao.Focus();
                    return;
                }

                // Tudo certo, remove erros anteriores
                errorProvider1.SetError(MtB_Admissao, "");
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

            if (MtB_Clien_Edit.Checked)
            {
                tB_Salario.Enabled = false;
                errorProvider1.SetError(tB_Salario, "");
            }
            else
            {
                tB_Salario.Enabled = true;

                TextBox txt = sender as TextBox;


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
        }


        private string ObterSexo()
        {
            if (MrB_Masculino.Checked) return "Masculino";
            if (MrB_Feminino.Checked) return "Feminino";
            if (MrB_Outro.Checked) return "Outro";
            if (MrB_Nao_Dizer.Checked) return "Prefiro não dizer";

            return string.Empty;
        }

        private string StatusFuncionario()
        {
            if (MrB_Ativo.Checked) return "Ativo";
            if (MrB_Inativo.Checked) return "Inativo";
            return string.Empty;
        }

        private string TipoUsuario()
        {
            if (MtB_Oper.Checked) return "Operador";
            if (MtB_Clien_Edit.Checked) return "Cliente";
            if (MtB_Clien_Edit.Checked == true)
            {
                Grupo_Dados_Contrato.Visible = false;
                
            }
            else
            {

                Grupo_Dados_Contrato.Visible = true;

            }
            return string.Empty;
        }


        #endregion


        #region Buttons de funcionalidade

        private string GerarMatricula()
        {

            string numeros = "0123456789";

            StringBuilder matricula = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {

                matricula.Append(numeros[random.Next(0, numeros.Length)]);

            }
            return matricula.ToString();
        }

        private void Clear()
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
            tB_Busca_Matricula.Clear();
        }

        private void MBNT_Limpar_Click(object sender, EventArgs e)
        {
            Clear();


            tB_id_Matricula.Text = GerarMatricula();

            DefinirEnabledNosCampos(this, true);
            tB_Busca_Matricula.Enabled = false;
            tB_id_Matricula.Enabled = false;
            tB_NomeCompleto.Focus();


        }


        private void MBNT_Editar_Click(object sender, EventArgs e)
        {

            EditarForm Edit = new EditarForm();
            Edit.ShowDialog();
            this.Show();
        }

        private void MBNT_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir este funcionário?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    // Obter a String da Conexão
                    string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";

                    // Criar um Objeto Funcionario
                    Funcionarios f = new Funcionarios()
                    {
                        UID_Funcionario = Convert.ToInt32(tB_Busca_Matricula.Text)
                    };

                    // Abrir conexão com o banco
                    using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                    {
                        conn.Open();

                        // QUERY
                        string sql = @"DELETE FROM pessoas WHERE uid_funcionario = @uid";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@uid", f.UID_Funcionario);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Funcionário apagado com sucesso!");

                        // Limpar os campos do formulário
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

                        DefinirEnabledNosCampos(this, false);
                    }
                }
                else
                {
                    MessageBox.Show("Exclusão cancelada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o funcionário: " + ex.Message);
            }
        }

        private void MBNT_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                // Obter a String da Conexão
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";

                // Criar um Objeto Funcionario
                Funcionarios f = new Funcionarios()
                {
                    UID_Funcionario = Convert.ToInt32(tB_id_Matricula.Text),
                    NomeCompleto_Funcionario = tB_NomeCompleto.Text,
                    CPF = MtB_CPF.Text,
                    Nascimento = DateTime.ParseExact(MtB_Nascimento.Text, "dd/MM/yyyy", null),
                    Idade = Calc_Idade(DateTime.ParseExact(MtB_Nascimento.Text, "dd/MM/yyyy", null)),
                    Sexo = ObterSexo(),
                    Telefone = MtB_Telefone.Text,
                    Email = tB_Email.Text,
                    Cep = MtB_Cep.Text,
                    Logradouro = tB_Logradouro.Text,
                    Bairro = tB_Bairro.Text,
                    Cidade = tB_Cidade.Text,
                    UF = tB_UF.Text,
                    Cargo = tB_Cargo.Text,
                    Data_Admissao = DateTime.ParseExact(MtB_Admissao.Text, "dd/MM/yyyy", null),
                    Salario = tB_Salario.Text,
                    Status = StatusFuncionario(),
                    Tipo_De_Usuario = TipoUsuario(),
                };


                // Abrir conexão com o banco
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();


                    // Verificar se o e-mail, CPF ou telefone já existem
                    string sqlVerificaDuplicados = @"SELECT email, cpf, telefone FROM pessoas 
                                                   WHERE email = @verifica_email OR cpf = @verifica_cpf OR telefone = @verifica_telefone";

                    using (NpgsqlCommand cmdVerifica = new NpgsqlCommand(sqlVerificaDuplicados, conn))
                    {
                        cmdVerifica.Parameters.AddWithValue("@verifica_email", f.Email);
                        cmdVerifica.Parameters.AddWithValue("@verifica_cpf", f.CPF);
                        cmdVerifica.Parameters.AddWithValue("@verifica_telefone", f.Telefone);

                        using (var reader = cmdVerifica.ExecuteReader())
                        {
                            bool duplicado = false;

                            while (reader.Read())
                            {
                                if (reader["email"].ToString() == f.Email)
                                {
                                    errorProvider1.SetError(tB_Email, "Este e-mail já está cadastrado.");
                                    duplicado = true;
                                }

                                if (reader["cpf"].ToString() == f.CPF)
                                {
                                    errorProvider1.SetError(MtB_CPF, "Este CPF já está cadastrado.");
                                    duplicado = true;
                                }

                                if (reader["telefone"].ToString() == f.Telefone)
                                {
                                    errorProvider1.SetError(MtB_Telefone, "Este telefone já está cadastrado.");
                                    duplicado = true;
                                }
                            }

                            if (duplicado)
                            {
                                return; // Sai do método sem tentar inserir
                            }
                        }
                    }
                    string sql = @"INSERT INTO pessoas (
                         uid_funcionario, nomecompleto_funcionario, cpf, nascimento, idade, sexo, telefone, email, cep,
                            logradouro, bairro, cidade, uf, cargo, data_admissao, salario, status, tipo_de_usuario)

                            VALUES (
                            @uid, @nome, @cpf, @nascimento, @idade, @sexo, @telefone, @email, @cep,
                            @logradouro, @bairro, @cidade, @uf, @cargo, @admissao, @salario, @status, @tipo_de_usuario)
                         ";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", f.UID_Funcionario);
                        cmd.Parameters.AddWithValue("@nome", f.NomeCompleto_Funcionario);
                        cmd.Parameters.AddWithValue("@cpf", f.CPF);
                        cmd.Parameters.AddWithValue("@nascimento", f.Nascimento);
                        cmd.Parameters.AddWithValue("@idade", f.Idade);
                        cmd.Parameters.AddWithValue("@sexo", f.Sexo);
                        cmd.Parameters.AddWithValue("@telefone", f.Telefone);
                        cmd.Parameters.AddWithValue("@email", f.Email);
                        cmd.Parameters.AddWithValue("@cep", f.Cep);
                        cmd.Parameters.AddWithValue("@logradouro", f.Logradouro);
                        cmd.Parameters.AddWithValue("@bairro", f.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", f.Cidade);
                        cmd.Parameters.AddWithValue("@uf", f.UF);
                        cmd.Parameters.AddWithValue("@cargo", f.Cargo);
                        cmd.Parameters.AddWithValue("@admissao", f.Data_Admissao);
                        cmd.Parameters.AddWithValue("@salario", f.Salario);
                        cmd.Parameters.AddWithValue("@status", f.Status);
                        cmd.Parameters.AddWithValue("@tipo_de_usuario", f.Tipo_De_Usuario);


                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Funcionário salvo com sucesso!");
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar o funcionário: " + ex.Message
                    );

            }
        }

        private void MBNT_Localizar_Click(object sender, EventArgs e)
        {
            DefinirEnabledNosCampos(this, false);
            tB_Salario.Enabled = false;
            tB_Busca_Matricula.Enabled = true;
            tB_id_Matricula.Clear();
            tB_Busca_Matricula.Focus();



            if (string.IsNullOrEmpty(tB_Busca_Matricula.Text))
            {
                return;
            }

            try
            {

                // obter a String de conexao
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";

                Funcionarios f = new Funcionarios()
                {
                    UID_Funcionario = Convert.ToInt32(tB_Busca_Matricula.Text)
                };

                // Abrir conexao com o banco
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    // QUERY
                    string sql = @"SELECT nomecompleto_funcionario, cpf, nascimento, idade, sexo, telefone, email, cep, logradouro, bairro, cidade, uf, cargo, data_admissao, salario, status, tipo_de_usuario FROM pessoas WHERE uid_funcionario = @uid";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", f.UID_Funcionario);

                        cmd.ExecuteNonQuery();

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preenchendo os TextBox com os dados da consulta
                                tB_NomeCompleto.Text = reader["nomecompleto_funcionario"].ToString();
                                tB_Email.Text = reader["email"].ToString();
                                MtB_Telefone.Text = reader["telefone"].ToString();
                                MtB_CPF.Text = reader["cpf"].ToString();
                                MtB_Nascimento.Text = reader["nascimento"].ToString();
                                MtB_Cep.Text = reader["cep"].ToString();
                                tB_Logradouro.Text = reader["logradouro"].ToString();
                                tB_Bairro.Text = reader["bairro"].ToString();
                                tB_Cidade.Text = reader["cidade"].ToString();
                                tB_UF.Text = reader["uf"].ToString();
                                tB_Cargo.Text = reader["cargo"].ToString();
                                MtB_Admissao.Text = reader["data_admissao"].ToString();
                                tB_Salario.Text = reader["salario"].ToString();
                                string sexo = reader["sexo"].ToString();

                                if (sexo == "Masculino")

                                    MrB_Masculino.Checked = true;
                                else if (sexo == "Feminino")
                                    MrB_Feminino.Checked = true;
                                else if (sexo == "Outro")
                                    MrB_Outro.Checked = true;
                                else if (sexo == "Prefiro não dizer")
                                    MrB_Nao_Dizer.Checked = true;

                                string Status = reader["status"].ToString();

                                if (Status == "Ativo")
                                    MrB_Ativo.Checked = true;
                                else if (Status == "Inativo")
                                    MrB_Inativo.Checked = true;

                                string Tipo = reader["tipo_de_usuario"].ToString();

                                if (Tipo == "Operador")
                                    MtB_Oper.Checked = true;
                                else if (Tipo == "Cliente")
                                    MtB_Clien_Edit.Checked = true;

                                if (MtB_Clien_Edit.Checked == true)
                                {
                                    Grupo_Dados_Contrato.Visible = false;
                                    return;
                                }
                                else
                                {
                                    Grupo_Dados_Contrato.Visible = true;

                                }
                            }
                            else
                            {
                                MessageBox.Show("Funcionário não encontrado.");
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar o funcionário: " + ex.Message
                    );
            }
        }



        #endregion


        

       

        
    }
}