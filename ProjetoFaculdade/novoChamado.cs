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
    public partial class novoChamado : Form
    {
        private string matricula;
        public novoChamado(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            
            tB_Informe_Matricula_Client.Enabled = false;
            tB_Informe_Matricula_Client.Text = matricula;
        }





        private void tB_Informe_Matricula_Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BT_Criar_Chamado_Click(object sender, EventArgs e)
        {
            string descricao = tB_Descricao_Erro.Text;
            string matricula = tB_Informe_Matricula_Client.Text;

            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira uma descrição.");
                return;
            }



            string connString = "Host=localhost;Username=postgres;Password=1@2b3!4?5#C;Database=pim";

            try
            {
                // Inserir no banco de dados
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO pim (matricula, descricao) VALUES (@matricula, @descricao)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("descricao", descricao);
                        cmd.Parameters.AddWithValue("matricula", matricula);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Chamado registrado com sucesso!");
                    tB_Descricao_Erro.Clear();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o chamado: " + ex.Message);
            }
        }

       
    }
}

