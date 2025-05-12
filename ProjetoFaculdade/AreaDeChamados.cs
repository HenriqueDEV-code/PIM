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
using static System.Net.Mime.MediaTypeNames;

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
            dataGridView_Oper.CellDoubleClick += dataGridView_Oper_CellDoubleClick;
            dataGridView_Oper.ReadOnly = true;
            CarregarChamados();

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
                                LB_Nome_Oper.Text = nomeCompleto;
                            }
                            else
                            {
                                nomeCompleto = "Não encontrado";
                                tipoUsuario = "Desconhecido";
                            }
                        }
                    }
                }

                this.Text = $"Área do Operador - {matricula} - {nomeCompleto}";
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

        private void CarregarChamados()
        {
            string connString = "Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim";
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM pim WHERE status IN ('Aberto', 'Em andamento') ORDER BY id ASC";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView_Oper.DataSource = dt;

                            // Ajusta larguras das colunas se existirem
                            if (dataGridView_Oper.Columns.Contains("id"))
                                dataGridView_Oper.Columns["id"].Width = 40;

                            if (dataGridView_Oper.Columns.Contains("descricao"))
                                dataGridView_Oper.Columns["descricao"].Width = 448;

                            if (dataGridView_Oper.Columns.Contains("status"))
                                dataGridView_Oper.Columns["status"].Width = 100;

                            if (dataGridView_Oper.Columns.Contains("operador"))
                                dataGridView_Oper.Columns["operador"].Width = 120;

                            if (dataGridView_Oper.Columns.Contains("data_abertura"))
                                dataGridView_Oper.Columns["data_abertura"].Width = 130;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Atualizar_Tabela_Oper_Click(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        private void dataGridView_Oper_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView_Oper.Columns.Contains("id"))
                {
                    var cellValue = dataGridView_Oper.Rows[e.RowIndex].Cells["id"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int chamadoId))
                    {
                        DetalheChamado detalhesForm = new DetalheChamado(chamadoId, matricula);
                        detalhesForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ID do chamado inválido ou nulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir detalhes do chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Pesquisar_Id_Chamado_Click(object sender, EventArgs e)
        {
            string id = tB_id_Chamado.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Digite algum ID.");
                return;
            }

            string connectionString = "Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pim WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(id));

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_Oper.DataSource = dt;
                    }
                }
            }
        }

        private void BT_Novo_Chamado_Oper_Click(object sender, EventArgs e)
        {
            novoChamado novaTela = new novoChamado();
            novaTela.ShowDialog();
            this.Show();

        }

        private void tB_id_Chamado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
