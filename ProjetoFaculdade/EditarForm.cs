using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

namespace ProjetoFaculdade
{
    public partial class EditarForm : Form
    {
        public EditarForm()
        {
            InitializeComponent();
            DefinirEnabledNosCampos(this, false);

        }

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


        // Realizei esse processo de Edição de usuário criando esse formulario


        #region TRATAMENTO DE ENTRADA DE DADOS EVENTO KEYPRESS
        private void tB_Busca_Matricula_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Permite a entrada
            }
        }
        private void tB_NomeCompleto_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Permite a entrada
            }
        }

        #endregion


        #region Localizar e Salvar Edicao de Cadastro
        private void MBNT_Localizar_Click(object sender, EventArgs e)
        {
            DefinirEnabledNosCampos(this, true);
            tB_Busca_Matricula_Edit.Focus();

            if (string.IsNullOrWhiteSpace(tB_Busca_Matricula_Edit.Text))
            {
                return;
            }

            try
            {

                // obter a String de conexao
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";

                Funcionarios f = new Funcionarios()
                {
                    UID_Funcionario = Convert.ToInt32(tB_Busca_Matricula_Edit.Text)
                };

                // Abrir conexao com o banco
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    // QUERY
                    string sql = @"SELECT nomecompleto_funcionario, telefone, email, cep, logradouro, bairro, cidade, uf, status, tipo_de_usuario FROM pessoas WHERE uid_funcionario = @uid";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", f.UID_Funcionario);

                        cmd.ExecuteNonQuery();

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tB_NomeCompleto_Edit.Text = reader["nomecompleto_funcionario"].ToString();
                                tB_Email_Edit.Text = reader["email"].ToString();
                                MtB_Telefone_Edit.Text = reader["telefone"].ToString();
                                MtB_Cep_Edit.Text = reader["cep"].ToString();
                                tB_Logradouro_Edit.Text = reader["logradouro"].ToString();
                                tB_Bairro_Edit.Text = reader["bairro"].ToString();
                                tB_Cidade_Edit.Text = reader["cidade"].ToString();
                                tB_UF_Edit.Text = reader["uf"].ToString();

                                string Status = reader["status"].ToString();
                                if (Status == "Ativo")
                                    MrB_Ativo_Edit.Checked = true;
                                else if (Status == "Inativo")
                                    MrB_Inativo_Edit.Checked = true;

                                string Tipo = reader["tipo_de_usuario"].ToString();
                                if (Tipo == "Operador")
                                    MtB_Oper_Edit.Checked = true;
                                else if (Tipo == "Cliente")
                                    MtB_Clien_Edit.Checked = true;
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



        private void BNT_Salvar_Edit_Click(object sender, EventArgs e)
        {
            

            try
            {
                // Obter a string de conexão
                string conexao = "Host=localhost;Port=5432;Database=car_tech_assist;Username=postgres;Password=1@2b3!4?5#C;";

                // Criar objeto com os dados atualizados
                Funcionarios f = new Funcionarios()
                {
                    UID_Funcionario = Convert.ToInt32(tB_Busca_Matricula_Edit.Text),
                    NomeCompleto_Funcionario = tB_NomeCompleto_Edit.Text,
                    Email = tB_Email_Edit.Text,
                    Telefone = MtB_Telefone_Edit.Text,
                    Cep = MtB_Cep_Edit.Text,
                    Logradouro = tB_Logradouro_Edit.Text,
                    Bairro = tB_Bairro_Edit.Text,
                    Cidade = tB_Cidade_Edit.Text,
                    UF = tB_UF_Edit.Text,
                    Status = MrB_Ativo_Edit.Checked ? "Ativo" : "Inativo",
                    Tipo_De_Usuario = MtB_Oper_Edit.Checked ? "Operador" : "Cliente"
                };

                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"
                         UPDATE pessoas SET 
                         nomecompleto_funcionario = @nome,
                         email = @email,
                         telefone = @telefone,
                         cep = @cep,
                         logradouro = @logradouro,
                         bairro = @bairro,
                         cidade = @cidade,
                         uf = @uf,
                        status = @status,
                        tipo_de_usuario = @tipo_de_usuario
                        WHERE uid_funcionario = @uid";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", f.NomeCompleto_Funcionario);
                        cmd.Parameters.AddWithValue("@email", f.Email);
                        cmd.Parameters.AddWithValue("@telefone", f.Telefone);
                        cmd.Parameters.AddWithValue("@cep", f.Cep);
                        cmd.Parameters.AddWithValue("@logradouro", f.Logradouro);
                        cmd.Parameters.AddWithValue("@bairro", f.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", f.Cidade);
                        cmd.Parameters.AddWithValue("@uf", f.UF);
                        cmd.Parameters.AddWithValue("@status", f.Status);
                        cmd.Parameters.AddWithValue("@tipo_de_usuario", f.Tipo_De_Usuario);
                        cmd.Parameters.AddWithValue("@uid", f.UID_Funcionario);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Funcionário atualizado com sucesso!");
                            tB_NomeCompleto_Edit.Clear();
                            tB_Email_Edit.Clear();
                            MtB_Telefone_Edit.Clear();
                            MtB_Cep_Edit.Clear();
                            tB_Logradouro_Edit.Clear();
                            tB_Bairro_Edit.Clear();
                            tB_Cidade_Edit.Clear();
                            tB_UF_Edit.Clear();
                            tB_Busca_Matricula_Edit.Clear();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado para atualização.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o funcionário: " + ex.Message);
            }
        }

        #endregion

        #region TRATAMENTO DE DADOS NULOS

        private void tB_Email_Edit_Leave(object sender, EventArgs e)
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

            string email = tB_Email_Edit.Text.Trim();

            // Aqui vamos verificar se o e-mail tem um formato mínimo válido

            if (!email.Contains("@") || email.Split('@').Length != 2)
            {
                MessageBox.Show("E-mail inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Email_Edit.Focus();
                return;
            }

            // Obtem o dominio digitado pelo usuario
            string dominio = "@" + email.Split('@')[1];

            // Verifica se o dominio esta na lista permitida
            bool dominioValido = Array.Exists(dominiosPermitidos, d => d.Equals(dominio, StringComparison.OrdinalIgnoreCase));

            if (!dominioValido)
            {
                errorProvider1.SetError(tB_NomeCompleto_Edit, "Dominio de E-mail inválido!");
                
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
        private void MtB_Telefone_Edit_Leave(object sender, EventArgs e)
        {
            string Telefone = new string(MtB_Telefone_Edit.Text.Where(char.IsDigit).ToArray()); // Remove tudo exceto números

            if (string.IsNullOrWhiteSpace(Telefone))
            {
                errorProvider1.SetError(MtB_Telefone_Edit, "O campo TELEFONE deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(MtB_Telefone_Edit, "");
            }

            // validar repetiçoes

            if (Digito(Telefone))
            {
                errorProvider1.SetError(MtB_Telefone_Edit, "Telefone inválido. Número repetitivo detectado.");
                return;
            }
            else
            {
                errorProvider1.SetError(MtB_Telefone_Edit, "");
            }

        }

        private void MtB_Cep_Edit_Leave(object sender, EventArgs e)
        {
            string cep = MtB_Cep_Edit.Text;
            // Remover espaços e caracteres desnecessários
            cep = cep.Trim().Replace(" ", "").Replace("-", "");

            if (string.IsNullOrWhiteSpace(cep))
            {
                errorProvider1.SetError(MtB_Cep_Edit, "O campo CEP deve ser preenchido");
            }
           else
            {
                errorProvider1.SetError(MtB_Cep_Edit, "");
            }

        }

        private async void MBNT_Pesquisa_CEP_Edit_Click(object sender, EventArgs e)
        {
            // Obtem o valor digitado
            string cep = MtB_Cep_Edit.Text;

            // Remover espaços e caracteres desnecessários
            cep = cep.Trim().Replace(" ", "").Replace("-", "");

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
                    tB_Logradouro_Edit.Text = logradouro;
                    tB_Bairro_Edit.Text = bairro;
                    tB_Cidade_Edit.Text = localidade;
                    tB_UF_Edit.Text = uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o endereço via CEP: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tB_NomeCompleto_Edit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tB_NomeCompleto_Edit.Text))
            {
                errorProvider1.SetError(tB_NomeCompleto_Edit, "O campo NOME deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(tB_NomeCompleto_Edit, "");
            }
        }

        #endregion




    }
}