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
    public partial class DetalheChamado : Form
    {
        private int chamadoId;
        private string matricula;
        private string nome;
        public DetalheChamado(int ID, string matricula)
        {
            InitializeComponent();
            chamadoId = ID;
            this.matricula = matricula;

        }

        private void DetalheChamado_Load(object sender, EventArgs e)
        {
            ConfigurarComboStatus();
            BuscarOperador();
            CarregarChamado();
        }

        private void BuscarOperador()
        {
            CB_Operador_Detalhes.Items.Clear();

            string connectionString = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";
            string query = "SELECT nomecompleto_funcionario FROM pessoas WHERE tipo_de_usuario = 'Operador'";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nome = reader["nomecompleto_funcionario"].ToString();
                                CB_Operador_Detalhes.Items.Add(nome);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar operadores: " + ex.Message);
            }
        }


        private void ConfigurarComboStatus()
        {
            CB_Status_Detalhe.Items.Clear();
            CB_Status_Detalhe.Items.Add("Aberto");
            CB_Status_Detalhe.Items.Add("Em andamento");
            CB_Status_Detalhe.Items.Add("Resolvido");
            CB_Status_Detalhe.Items.Add("Fechado");
        }
       

        private void CarregarChamado()
        {

            string connString = "Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim";


            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT matricula, descricao, status, operador, data_abertura FROM pim WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", chamadoId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tB_id_Chamado_Detalhes.Text = reader.GetString(0);
                            tB_Descricao_Detalhes.Text = reader.GetString(1);
                            CB_Status_Detalhe.SelectedItem = reader.GetString(2);
                            CB_Operador_Detalhes.SelectedItem = reader.IsDBNull(3) ? null : reader.GetString(3);
                            tB_Data_Detalhe.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy HH:mm");
                        }
                        else
                        {
                            MessageBox.Show("Chamado não encontrado!");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void BT_Salvar_Detalhe_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim"))
            {
                conn.Open();
                string update = "UPDATE pim SET status = @status, operador = @operador WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("status", CB_Status_Detalhe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("operador", CB_Operador_Detalhes.Text);
                    cmd.Parameters.AddWithValue("id", chamadoId);

                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
            CarregarChamado();
            MessageBox.Show("Chamado atualizado com sucesso!");
            this.Close();
        }
    }
}
