using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #endregion


    }
}
