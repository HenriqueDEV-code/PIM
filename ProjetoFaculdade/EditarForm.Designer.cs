namespace ProjetoFaculdade
{
    partial class EditarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBNT_Localizar = new MetroFramework.Controls.MetroButton();
            this.tB_Busca_Matricula_Edit = new System.Windows.Forms.TextBox();
            this.Grupo_Endereco = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tB_UF_Edit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tB_Cidade_Edit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tB_Bairro_Edit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tB_Logradouro_Edit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MBNT_Pesquisa_CEP_Edit = new MetroFramework.Controls.MetroButton();
            this.MtB_Cep_Edit = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Grupo_Dados_P_Funcionarios = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MtB_Telefone_Edit = new System.Windows.Forms.MaskedTextBox();
            this.tB_Email_Edit = new System.Windows.Forms.TextBox();
            this.tB_NomeCompleto_Edit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Grupo_Status = new System.Windows.Forms.GroupBox();
            this.MrB_Inativo_Edit = new MetroFramework.Controls.MetroRadioButton();
            this.MrB_Ativo_Edit = new MetroFramework.Controls.MetroRadioButton();
            this.BNT_Salvar_Edit = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.Grupo_Endereco.SuspendLayout();
            this.Grupo_Dados_P_Funcionarios.SuspendLayout();
            this.Grupo_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBNT_Localizar);
            this.groupBox1.Controls.Add(this.tB_Busca_Matricula_Edit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1484, 70);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCA";
            // 
            // MBNT_Localizar
            // 
            this.MBNT_Localizar.Highlight = false;
            this.MBNT_Localizar.Location = new System.Drawing.Point(276, 18);
            this.MBNT_Localizar.Margin = new System.Windows.Forms.Padding(4);
            this.MBNT_Localizar.Name = "MBNT_Localizar";
            this.MBNT_Localizar.Size = new System.Drawing.Size(114, 36);
            this.MBNT_Localizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.MBNT_Localizar.StyleManager = null;
            this.MBNT_Localizar.TabIndex = 23;
            this.MBNT_Localizar.Text = "Localizar Usuário";
            this.MBNT_Localizar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MBNT_Localizar.Click += new System.EventHandler(this.MBNT_Localizar_Click);
            // 
            // tB_Busca_Matricula_Edit
            // 
            this.tB_Busca_Matricula_Edit.BackColor = System.Drawing.Color.White;
            this.tB_Busca_Matricula_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Busca_Matricula_Edit.Location = new System.Drawing.Point(26, 21);
            this.tB_Busca_Matricula_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Busca_Matricula_Edit.Name = "tB_Busca_Matricula_Edit";
            this.tB_Busca_Matricula_Edit.Size = new System.Drawing.Size(242, 31);
            this.tB_Busca_Matricula_Edit.TabIndex = 29;
            this.tB_Busca_Matricula_Edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Busca_Matricula_Edit_KeyPress);
            // 
            // Grupo_Endereco
            // 
            this.Grupo_Endereco.Controls.Add(this.label29);
            this.Grupo_Endereco.Controls.Add(this.tB_UF_Edit);
            this.Grupo_Endereco.Controls.Add(this.label16);
            this.Grupo_Endereco.Controls.Add(this.tB_Cidade_Edit);
            this.Grupo_Endereco.Controls.Add(this.label15);
            this.Grupo_Endereco.Controls.Add(this.tB_Bairro_Edit);
            this.Grupo_Endereco.Controls.Add(this.label14);
            this.Grupo_Endereco.Controls.Add(this.tB_Logradouro_Edit);
            this.Grupo_Endereco.Controls.Add(this.label13);
            this.Grupo_Endereco.Controls.Add(this.MBNT_Pesquisa_CEP_Edit);
            this.Grupo_Endereco.Controls.Add(this.MtB_Cep_Edit);
            this.Grupo_Endereco.Controls.Add(this.label12);
            this.Grupo_Endereco.ForeColor = System.Drawing.Color.White;
            this.Grupo_Endereco.Location = new System.Drawing.Point(13, 351);
            this.Grupo_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.Grupo_Endereco.Name = "Grupo_Endereco";
            this.Grupo_Endereco.Padding = new System.Windows.Forms.Padding(4);
            this.Grupo_Endereco.Size = new System.Drawing.Size(1488, 190);
            this.Grupo_Endereco.TabIndex = 21;
            this.Grupo_Endereco.TabStop = false;
            this.Grupo_Endereco.Text = "ENDEREÇO";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(390, 9);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 17);
            this.label29.TabIndex = 37;
            this.label29.Text = "*";
            // 
            // tB_UF_Edit
            // 
            this.tB_UF_Edit.BackColor = System.Drawing.Color.White;
            this.tB_UF_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_UF_Edit.Location = new System.Drawing.Point(781, 128);
            this.tB_UF_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_UF_Edit.Name = "tB_UF_Edit";
            this.tB_UF_Edit.ReadOnly = true;
            this.tB_UF_Edit.Size = new System.Drawing.Size(62, 31);
            this.tB_UF_Edit.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(726, 133);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 26);
            this.label16.TabIndex = 26;
            this.label16.Text = "UF:";
            // 
            // tB_Cidade_Edit
            // 
            this.tB_Cidade_Edit.BackColor = System.Drawing.Color.White;
            this.tB_Cidade_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Cidade_Edit.Location = new System.Drawing.Point(213, 128);
            this.tB_Cidade_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Cidade_Edit.Name = "tB_Cidade_Edit";
            this.tB_Cidade_Edit.ReadOnly = true;
            this.tB_Cidade_Edit.Size = new System.Drawing.Size(425, 31);
            this.tB_Cidade_Edit.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(116, 133);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 26);
            this.label15.TabIndex = 24;
            this.label15.Text = "Cidade:";
            // 
            // tB_Bairro_Edit
            // 
            this.tB_Bairro_Edit.BackColor = System.Drawing.Color.White;
            this.tB_Bairro_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Bairro_Edit.Location = new System.Drawing.Point(781, 74);
            this.tB_Bairro_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Bairro_Edit.Name = "tB_Bairro_Edit";
            this.tB_Bairro_Edit.ReadOnly = true;
            this.tB_Bairro_Edit.Size = new System.Drawing.Size(425, 31);
            this.tB_Bairro_Edit.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(697, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 26);
            this.label14.TabIndex = 22;
            this.label14.Text = "Bairro:";
            // 
            // tB_Logradouro_Edit
            // 
            this.tB_Logradouro_Edit.BackColor = System.Drawing.Color.White;
            this.tB_Logradouro_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Logradouro_Edit.Location = new System.Drawing.Point(212, 74);
            this.tB_Logradouro_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Logradouro_Edit.Name = "tB_Logradouro_Edit";
            this.tB_Logradouro_Edit.ReadOnly = true;
            this.tB_Logradouro_Edit.Size = new System.Drawing.Size(425, 31);
            this.tB_Logradouro_Edit.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(92, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Endereço:";
            // 
            // MBNT_Pesquisa_CEP_Edit
            // 
            this.MBNT_Pesquisa_CEP_Edit.Highlight = false;
            this.MBNT_Pesquisa_CEP_Edit.Location = new System.Drawing.Point(416, 19);
            this.MBNT_Pesquisa_CEP_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.MBNT_Pesquisa_CEP_Edit.Name = "MBNT_Pesquisa_CEP_Edit";
            this.MBNT_Pesquisa_CEP_Edit.Size = new System.Drawing.Size(100, 36);
            this.MBNT_Pesquisa_CEP_Edit.Style = MetroFramework.MetroColorStyle.Blue;
            this.MBNT_Pesquisa_CEP_Edit.StyleManager = null;
            this.MBNT_Pesquisa_CEP_Edit.TabIndex = 19;
            this.MBNT_Pesquisa_CEP_Edit.Text = "Pesquisar";
            this.MBNT_Pesquisa_CEP_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MBNT_Pesquisa_CEP_Edit.Click += new System.EventHandler(this.MBNT_Pesquisa_CEP_Edit_Click);
            // 
            // MtB_Cep_Edit
            // 
            this.MtB_Cep_Edit.BackColor = System.Drawing.Color.White;
            this.MtB_Cep_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MtB_Cep_Edit.Location = new System.Drawing.Point(216, 24);
            this.MtB_Cep_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.MtB_Cep_Edit.Mask = "00000 - 000";
            this.MtB_Cep_Edit.Name = "MtB_Cep_Edit";
            this.MtB_Cep_Edit.Size = new System.Drawing.Size(175, 31);
            this.MtB_Cep_Edit.TabIndex = 18;
            this.MtB_Cep_Edit.ValidatingType = typeof(System.DateTime);
            this.MtB_Cep_Edit.Leave += new System.EventHandler(this.MtB_Cep_Edit_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(144, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "CEP:";
            // 
            // Grupo_Dados_P_Funcionarios
            // 
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.Grupo_Status);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label28);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label25);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label3);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label4);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.MtB_Telefone_Edit);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.tB_Email_Edit);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.tB_NomeCompleto_Edit);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label9);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label8);
            this.Grupo_Dados_P_Funcionarios.Controls.Add(this.label7);
            this.Grupo_Dados_P_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Grupo_Dados_P_Funcionarios.ForeColor = System.Drawing.Color.White;
            this.Grupo_Dados_P_Funcionarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grupo_Dados_P_Funcionarios.Location = new System.Drawing.Point(13, 89);
            this.Grupo_Dados_P_Funcionarios.Margin = new System.Windows.Forms.Padding(4);
            this.Grupo_Dados_P_Funcionarios.Name = "Grupo_Dados_P_Funcionarios";
            this.Grupo_Dados_P_Funcionarios.Padding = new System.Windows.Forms.Padding(4);
            this.Grupo_Dados_P_Funcionarios.Size = new System.Drawing.Size(1488, 254);
            this.Grupo_Dados_P_Funcionarios.TabIndex = 20;
            this.Grupo_Dados_P_Funcionarios.TabStop = false;
            this.Grupo_Dados_P_Funcionarios.Text = "DADOS PESSOAIS";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(891, 125);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 17);
            this.label28.TabIndex = 40;
            this.label28.Text = "*";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(453, 125);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 17);
            this.label25.TabIndex = 37;
            this.label25.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1135, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1135, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "*";
            // 
            // MtB_Telefone_Edit
            // 
            this.MtB_Telefone_Edit.BackColor = System.Drawing.Color.White;
            this.MtB_Telefone_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MtB_Telefone_Edit.Location = new System.Drawing.Point(216, 146);
            this.MtB_Telefone_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.MtB_Telefone_Edit.Mask = "(99) 0 0000 - 0000";
            this.MtB_Telefone_Edit.Name = "MtB_Telefone_Edit";
            this.MtB_Telefone_Edit.Size = new System.Drawing.Size(239, 31);
            this.MtB_Telefone_Edit.TabIndex = 31;
            this.MtB_Telefone_Edit.Leave += new System.EventHandler(this.MtB_Telefone_Edit_Leave);
            // 
            // tB_Email_Edit
            // 
            this.tB_Email_Edit.BackColor = System.Drawing.Color.White;
            this.tB_Email_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Email_Edit.Location = new System.Drawing.Point(217, 86);
            this.tB_Email_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Email_Edit.Name = "tB_Email_Edit";
            this.tB_Email_Edit.Size = new System.Drawing.Size(920, 31);
            this.tB_Email_Edit.TabIndex = 30;
            this.tB_Email_Edit.Leave += new System.EventHandler(this.tB_Email_Edit_Leave);
            // 
            // tB_NomeCompleto_Edit
            // 
            this.tB_NomeCompleto_Edit.BackColor = System.Drawing.Color.White;
            this.tB_NomeCompleto_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_NomeCompleto_Edit.Location = new System.Drawing.Point(216, 29);
            this.tB_NomeCompleto_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.tB_NomeCompleto_Edit.Name = "tB_NomeCompleto_Edit";
            this.tB_NomeCompleto_Edit.Size = new System.Drawing.Size(921, 31);
            this.tB_NomeCompleto_Edit.TabIndex = 29;
            this.tB_NomeCompleto_Edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_NomeCompleto_Edit_KeyPress);
            this.tB_NomeCompleto_Edit.Leave += new System.EventHandler(this.tB_NomeCompleto_Edit_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(97, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(116, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome Completo:";
            // 
            // Grupo_Status
            // 
            this.Grupo_Status.Controls.Add(this.MrB_Inativo_Edit);
            this.Grupo_Status.Controls.Add(this.MrB_Ativo_Edit);
            this.Grupo_Status.ForeColor = System.Drawing.Color.White;
            this.Grupo_Status.Location = new System.Drawing.Point(575, 125);
            this.Grupo_Status.Margin = new System.Windows.Forms.Padding(4);
            this.Grupo_Status.Name = "Grupo_Status";
            this.Grupo_Status.Padding = new System.Windows.Forms.Padding(4);
            this.Grupo_Status.Size = new System.Drawing.Size(308, 88);
            this.Grupo_Status.TabIndex = 41;
            this.Grupo_Status.TabStop = false;
            this.Grupo_Status.Text = "STATUS";
            // 
            // MrB_Inativo_Edit
            // 
            this.MrB_Inativo_Edit.AutoSize = true;
            this.MrB_Inativo_Edit.CustomBackground = false;
            this.MrB_Inativo_Edit.FontSize = MetroFramework.MetroLinkSize.Small;
            this.MrB_Inativo_Edit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.MrB_Inativo_Edit.Location = new System.Drawing.Point(207, 25);
            this.MrB_Inativo_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.MrB_Inativo_Edit.Name = "MrB_Inativo_Edit";
            this.MrB_Inativo_Edit.Size = new System.Drawing.Size(59, 15);
            this.MrB_Inativo_Edit.Style = MetroFramework.MetroColorStyle.Blue;
            this.MrB_Inativo_Edit.StyleManager = null;
            this.MrB_Inativo_Edit.TabIndex = 1;
            this.MrB_Inativo_Edit.TabStop = true;
            this.MrB_Inativo_Edit.Text = "Inativo";
            this.MrB_Inativo_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MrB_Inativo_Edit.UseStyleColors = false;
            this.MrB_Inativo_Edit.UseVisualStyleBackColor = true;
            // 
            // MrB_Ativo_Edit
            // 
            this.MrB_Ativo_Edit.AutoSize = true;
            this.MrB_Ativo_Edit.CustomBackground = false;
            this.MrB_Ativo_Edit.FontSize = MetroFramework.MetroLinkSize.Small;
            this.MrB_Ativo_Edit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.MrB_Ativo_Edit.Location = new System.Drawing.Point(24, 25);
            this.MrB_Ativo_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.MrB_Ativo_Edit.Name = "MrB_Ativo_Edit";
            this.MrB_Ativo_Edit.Size = new System.Drawing.Size(51, 15);
            this.MrB_Ativo_Edit.Style = MetroFramework.MetroColorStyle.Blue;
            this.MrB_Ativo_Edit.StyleManager = null;
            this.MrB_Ativo_Edit.TabIndex = 0;
            this.MrB_Ativo_Edit.TabStop = true;
            this.MrB_Ativo_Edit.Text = "Ativo";
            this.MrB_Ativo_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MrB_Ativo_Edit.UseStyleColors = false;
            this.MrB_Ativo_Edit.UseVisualStyleBackColor = true;
            // 
            // BNT_Salvar_Edit
            // 
            this.BNT_Salvar_Edit.Highlight = false;
            this.BNT_Salvar_Edit.Location = new System.Drawing.Point(1398, 583);
            this.BNT_Salvar_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.BNT_Salvar_Edit.Name = "BNT_Salvar_Edit";
            this.BNT_Salvar_Edit.Size = new System.Drawing.Size(114, 36);
            this.BNT_Salvar_Edit.Style = MetroFramework.MetroColorStyle.Blue;
            this.BNT_Salvar_Edit.StyleManager = null;
            this.BNT_Salvar_Edit.TabIndex = 24;
            this.BNT_Salvar_Edit.Text = "Salvar";
            this.BNT_Salvar_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BNT_Salvar_Edit.Click += new System.EventHandler(this.BNT_Salvar_Edit_Click);
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1525, 632);
            this.Controls.Add(this.BNT_Salvar_Edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grupo_Endereco);
            this.Controls.Add(this.Grupo_Dados_P_Funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grupo_Endereco.ResumeLayout(false);
            this.Grupo_Endereco.PerformLayout();
            this.Grupo_Dados_P_Funcionarios.ResumeLayout(false);
            this.Grupo_Dados_P_Funcionarios.PerformLayout();
            this.Grupo_Status.ResumeLayout(false);
            this.Grupo_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroButton MBNT_Localizar;
        public System.Windows.Forms.TextBox tB_Busca_Matricula_Edit;
        private System.Windows.Forms.GroupBox Grupo_Endereco;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tB_UF_Edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tB_Cidade_Edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tB_Bairro_Edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tB_Logradouro_Edit;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroButton MBNT_Pesquisa_CEP_Edit;
        public System.Windows.Forms.MaskedTextBox MtB_Cep_Edit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Grupo_Dados_P_Funcionarios;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox MtB_Telefone_Edit;
        public System.Windows.Forms.TextBox tB_Email_Edit;
        public System.Windows.Forms.TextBox tB_NomeCompleto_Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Grupo_Status;
        private MetroFramework.Controls.MetroRadioButton MrB_Inativo_Edit;
        private MetroFramework.Controls.MetroRadioButton MrB_Ativo_Edit;
        public MetroFramework.Controls.MetroButton BNT_Salvar_Edit;
    }
}