using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFaculdade
{
    public partial class AreaDeChamados : Form
    {
        private string matricula;
        private string nomeCompleto;
        private string tipoUsuario;

        public AreaDeChamados(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            BuscarNomeNoBanco();
            
        }

        private void BuscarNomeNoBanco()
        {
            string connectionString = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
            string query = "SELECT nomecompleto_funcionario, tipo_de_usuario FROM pessoas WHERE uid_funcionario = @matricula";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        if (int.TryParse(matricula, out int matriculaInt))
                        {
                            cmd.Parameters.AddWithValue("@matricula", matriculaInt);
                        }
                        else
                        {
                            MessageBox.Show("Erro: matrícula inválida.");
                            nomeCompleto = "Inválida";
                            tipoUsuario = "Desconhecido";
                            MButton_Cadastro.Visible = false;
                            return;
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nomeCompleto = reader["nomecompleto_funcionario"].ToString();
                                tipoUsuario = reader["tipo_de_usuario"].ToString();
                            }
                            else
                            {
                                nomeCompleto = "Não encontrado";
                                tipoUsuario = "Desconhecido";
                            }
                        }
                    }
                }

                this.Text = $"Área de Chamados - {matricula} - {nomeCompleto}";
                MButton_Cadastro.Visible = tipoUsuario.Trim().ToLower() != "cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar nome no banco: " + ex.Message);
                nomeCompleto = "Erro";
                tipoUsuario = "Erro";
                MButton_Cadastro.Visible = false;
            }
        }

        private void MButton_Cadastro_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios cadastro = new FormCadastroFuncionarios();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
            
        }
    }
}
