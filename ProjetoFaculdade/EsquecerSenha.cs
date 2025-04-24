using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Npgsql;
using static ProjetoFaculdade.EsquecerSenha;

namespace ProjetoFaculdade
{
    public partial class EsquecerSenha : Form
    {
        private string codigoVerificacao;
        private string emailFuncionario; 
        private string senhaTemporaria;



        public EsquecerSenha()
        {
            InitializeComponent();
        }

        public class Email_Service
        {
            private readonly string smtpServer = "smtp.gmail.com";
            private readonly int smtpPort = 587;
            private readonly string smtpUser = "cartech.assist@gmail.com";
            private readonly string smtpPass = "ydsc krne oisr rxbu";

            public void Enviar_Email(string assunto, string corpo, string emailDestino)
            {
                using (var smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(smtpUser, smtpPass),
                    EnableSsl = true,
                })
                using (var mailMessage = new MailMessage
                {
                    From = new MailAddress(smtpUser),
                    Subject = assunto,
                    Body = corpo,
                    IsBodyHtml = false,
                })
                {
                    mailMessage.To.Add(emailDestino);

                    try
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("E-mail enviado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}");
                    }
                }
            }

            public void EnviarSenhaTemporaria(string senha, string emailDestino)
            {
                string assunto = "Senha Temporária - Recuperação de Acesso";
                string corpo = $"Sua nova senha temporária é: {senha}\n\nRecomendamos que você a altere assim que acessar o sistema.";
                Enviar_Email(assunto, corpo, emailDestino);
            }
        }

        public void MBNT_Verificar_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var emailService = new Email_Service();

            if (MtB_Codigo_Verificacao.Text == codigoVerificacao)
            {
                label_Senha_Temp.Visible = true;
                label_Senha.Visible = true;
                label_Senha_Confirm.Visible = true;
                tB_Senha_Temp.Visible = true;
                tB_New_Senha.Visible = true;
                tB_Confir_New_Senha.Visible = true;
                BnT_Verificar_Senha_Temp.Visible = true;

                MessageBox.Show("Código verificado! Gerando e enviando senha temporária...");

                string numeros = "0123456789";
                string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                string especial = "!@#$%&";
                string todosCaracteres = letras + numeros + especial;

                StringBuilder sbSenhaTemporaria = new StringBuilder();
                for (int i = 0; i < 12; i++)
                {
                    sbSenhaTemporaria.Append(todosCaracteres[random.Next(todosCaracteres.Length)]);
                }

                senhaTemporaria = sbSenhaTemporaria.ToString(); // Armazena para validação posterior
                emailService.EnviarSenhaTemporaria(senhaTemporaria, emailFuncionario);

                // GRAVAR A SENHA TEMPORÁRIA NO BANCO
                try
                {
                    using (var conexao = new NpgsqlConnection("Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;"))
                    {
                        conexao.Open();
                        string query = @"UPDATE funcionarios SET senha = @senha WHERE email = @email";
                        using (var comando = new NpgsqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@senha", senhaTemporaria);
                            comando.Parameters.AddWithValue("@email", emailFuncionario);
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a senha temporária no banco: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Código de verificação inválido.");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MtB_Busca_Matricula_Senha.Text))
            {
                MessageBox.Show("Informe a matrícula.");
                return;
            }

            try
            {
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
                int matricula = Convert.ToInt32(MtB_Busca_Matricula_Senha.Text);

                using (var conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();
                    string sql = @"SELECT email FROM funcionarios WHERE uid_Funcionario = @uid";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", matricula);
                        var reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            emailFuncionario = reader.GetString(0);
                            var random = new Random();
                            codigoVerificacao = random.Next(100000, 999999).ToString();

                            var emailService = new Email_Service();
                            emailService.Enviar_Email("Código de Verificação", $"Seu código é: {codigoVerificacao}", emailFuncionario);
                        }
                        else
                        {
                            MessageBox.Show("Matrícula não encontrada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MtB_Codigo_Verificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void BnT_Verificar_Senha_Temp_Click(object sender, EventArgs e)
        {
            if (tB_Senha_Temp.Text != senhaTemporaria)
            {
                MessageBox.Show("Senha temporária incorreta.");
                return;
            }

            if (tB_New_Senha.Text != tB_Confir_New_Senha.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tB_New_Senha.Text))
            {
                MessageBox.Show("A nova senha não pode estar vazia.");
                return;
            }

            try
            {
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
                using (var conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();
                    string sql = @"UPDATE funcionarios SET senha = @novaSenha WHERE email = @Email";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@novaSenha", tB_New_Senha.Text); 
                        cmd.Parameters.AddWithValue("@Email", emailFuncionario);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha alterada com sucesso!");
                            this.Close(); // Ou redireciona para o login
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar a senha.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar senha: " + ex.Message);
            }

        }
    }



}
