using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoFaculdade
{
    public partial class FormLogin: Form
    {

       
        public FormLogin()
        {
            InitializeComponent();

            
        }
        private void Esqueceu_Senha_Click(object sender, EventArgs e)
        {
            EsquecerSenha Senhas = new EsquecerSenha();
            Senhas.ShowDialog();
            this.Show();
        }

        private void tB_Usuario_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void MButon_Login_Click(object sender, EventArgs e)
        {

            string connectionString = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
            string matricula = tB_Usuario_Login.Text.Trim();
            string senha = tB_Senha_Usuario.Text.Trim();

            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(matricula, out int uidFuncionario))
            {
                MessageBox.Show("Matrícula inválida. Use apenas números.");
                return;
            }

            Funcionarios f = new Funcionarios()
            {
                UID_Funcionario = uidFuncionario,
                Senha = senha,
            };

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string senhaCriptografada = Seguranca.GerarHashSHA256(f.Senha);

                    string sql = @"SELECT tipo_de_usuario FROM pessoas WHERE uid_funcionario = @matricula AND senha = @senha";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricula", f.UID_Funcionario);
                        cmd.Parameters.AddWithValue("@senha", senhaCriptografada);

                        object tipoObj = cmd.ExecuteScalar();

                        if (tipoObj != null)
                        {
                            string tipoUsuario = tipoObj.ToString().Trim().ToLower();
                           

                            if (tipoUsuario == "cliente")
                            {
                                TelaCliente cliente = new TelaCliente(matricula);
                                this.Hide();
                                cliente.ShowDialog();
                                this.Show();
                            }
                            else if (tipoUsuario == "operador")
                            {
                                AreaDeChamados chamados = new AreaDeChamados(matricula);
                                this.Hide();
                                chamados.ShowDialog();
                                this.Show();
                                tB_Senha_Usuario.Clear();
                            }
                            else
                            {
                                MessageBox.Show($"Tipo de usuário não reconhecido: {tipoUsuario}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Matrícula ou senha inválida.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
            }
        }

        private void tB_Usuario_Login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_Usuario_Login.Text))
            {
                errorProvider1.SetError(tB_Usuario_Login, "O campo Matricula é obrigatório.");
            }
            else
            {
                errorProvider1.SetError(tB_Usuario_Login, "");
            }
        }

        private void tB_Senha_Usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_Senha_Usuario.Text))
            {
                errorProvider1.SetError(tB_Senha_Usuario, "O campo Senha é obrigatório.");
            }
            else
            {
                errorProvider1.SetError(tB_Senha_Usuario, "");
            }
        }

        private void Ocultar_Senha_Click(object sender, EventArgs e)
        {
            tB_Senha_Usuario.PasswordChar = '\0';
            Ocultar_Senha.Visible = false;
            Mostrar_Senha.Visible = true;
        }

        private void Mostrar_Senha_Click(object sender, EventArgs e)
        {
            tB_Senha_Usuario.PasswordChar = '*';
            Mostrar_Senha.Visible = false;
            Ocultar_Senha.Visible = true;
        }
    }
}
