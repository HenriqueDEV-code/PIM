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
    public partial class TelaCliente : Form
    {
        private string matricula;
        private string nomeCompleto;
       

        public TelaCliente(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            BuscarNomeNoBanco();
        }

        private void BuscarNomeNoBanco()
        {
            string connectionString = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
            string query = "SELECT nomecompleto_funcionario FROM pessoas WHERE uid_funcionario = @matricula";

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
                            return;
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nomeCompleto = reader["nomecompleto_funcionario"].ToString();
                            }
                            else
                            {
                                nomeCompleto = "Não encontrado";
                            }
                        }
                    }
                }

                // Define o título da janela
                this.Text = $"Área do Cliente - {matricula} - {nomeCompleto}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar nome no banco: " + ex.Message);
                nomeCompleto = "Erro";
                this.Text = $"Área do Cliente - {matricula} - {nomeCompleto}";
            }
        }
    }
}
 
