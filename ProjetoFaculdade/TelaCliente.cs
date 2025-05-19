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
            tB_Exibe_Maticula_Cliente.Enabled = false;
            tB_Exibe_Maticula_Cliente.Text = matricula;

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
                                LB_Nome_Cliente.Text = nomeCompleto;
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

        private void CarregarChamados()
        {
            string connString = "Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Query sem a coluna "id"
                    string query = "SELECT matricula, descricao, status, operador, data_abertura FROM pim WHERE matricula = @matricula ORDER BY id ASC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matricula", matricula);

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView_Cliente.DataSource = dt;

                            // Ajusta larguras das colunas restantes
                            if (dataGridView_Cliente.Columns.Contains("descricao"))
                                dataGridView_Cliente.Columns["descricao"].Width = 480;

                            if (dataGridView_Cliente.Columns.Contains("status"))
                                dataGridView_Cliente.Columns["status"].Width = 120;

                            if (dataGridView_Cliente.Columns.Contains("operador"))
                                dataGridView_Cliente.Columns["operador"].Width = 120;

                            if (dataGridView_Cliente.Columns.Contains("data_abertura"))
                                dataGridView_Cliente.Columns["data_abertura"].Width = 140;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        private void BT_Atualizar_Tabela_Click(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        private void BT_Novo_Chamado_Click(object sender, EventArgs e)
        {
            novoChamado novaTela = new novoChamado(matricula);
            novaTela.ShowDialog();
            this.Show();
        }



    }
}

