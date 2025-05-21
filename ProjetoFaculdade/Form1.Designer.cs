namespace ProjetoFaculdade
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Tech_Titulo_Login = new System.Windows.Forms.Label();
            this.label_Car_Titulo_Login = new System.Windows.Forms.Label();
            this.MButon_Login = new MetroFramework.Controls.MetroButton();
            this.tB_Senha_Usuario = new System.Windows.Forms.TextBox();
            this.Esqueceu_Senha = new System.Windows.Forms.Label();
            this.tB_Usuario_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abel_Support_Titulo_Cadastro = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Ocultar_Senha = new System.Windows.Forms.PictureBox();
            this.Mostrar_Senha = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Tech_Titulo_Login
            // 
            this.label_Tech_Titulo_Login.AutoSize = true;
            this.label_Tech_Titulo_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label_Tech_Titulo_Login.ForeColor = System.Drawing.Color.Yellow;
            this.label_Tech_Titulo_Login.Location = new System.Drawing.Point(407, 61);
            this.label_Tech_Titulo_Login.Name = "label_Tech_Titulo_Login";
            this.label_Tech_Titulo_Login.Size = new System.Drawing.Size(128, 54);
            this.label_Tech_Titulo_Login.TabIndex = 8;
            this.label_Tech_Titulo_Login.Text = "Tech";
            this.label_Tech_Titulo_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Car_Titulo_Login
            // 
            this.label_Car_Titulo_Login.AutoSize = true;
            this.label_Car_Titulo_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label_Car_Titulo_Login.ForeColor = System.Drawing.Color.White;
            this.label_Car_Titulo_Login.Location = new System.Drawing.Point(311, 61);
            this.label_Car_Titulo_Login.Name = "label_Car_Titulo_Login";
            this.label_Car_Titulo_Login.Size = new System.Drawing.Size(99, 54);
            this.label_Car_Titulo_Login.TabIndex = 7;
            this.label_Car_Titulo_Login.Text = "Car";
            this.label_Car_Titulo_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MButon_Login
            // 
            this.MButon_Login.Highlight = false;
            this.MButon_Login.Location = new System.Drawing.Point(378, 243);
            this.MButon_Login.Name = "MButon_Login";
            this.MButon_Login.Size = new System.Drawing.Size(200, 55);
            this.MButon_Login.Style = MetroFramework.MetroColorStyle.Blue;
            this.MButon_Login.StyleManager = null;
            this.MButon_Login.TabIndex = 16;
            this.MButon_Login.Text = "&Login";
            this.MButon_Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MButon_Login.Click += new System.EventHandler(this.MButon_Login_Click);
            // 
            // tB_Senha_Usuario
            // 
            this.tB_Senha_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Senha_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tB_Senha_Usuario.Location = new System.Drawing.Point(83, 174);
            this.tB_Senha_Usuario.Name = "tB_Senha_Usuario";
            this.tB_Senha_Usuario.PasswordChar = '*';
            this.tB_Senha_Usuario.Size = new System.Drawing.Size(495, 53);
            this.tB_Senha_Usuario.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tB_Senha_Usuario, "Digite a sua senha.");
            this.tB_Senha_Usuario.Leave += new System.EventHandler(this.tB_Senha_Usuario_Leave);
            // 
            // Esqueceu_Senha
            // 
            this.Esqueceu_Senha.AutoSize = true;
            this.Esqueceu_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Esqueceu_Senha.ForeColor = System.Drawing.Color.White;
            this.Esqueceu_Senha.Location = new System.Drawing.Point(78, 263);
            this.Esqueceu_Senha.Name = "Esqueceu_Senha";
            this.Esqueceu_Senha.Size = new System.Drawing.Size(203, 25);
            this.Esqueceu_Senha.TabIndex = 15;
            this.Esqueceu_Senha.Text = "&Esqueceu a senha?";
            this.toolTip1.SetToolTip(this.Esqueceu_Senha, "Esqueceu Senha ou                             \r\nÉ seu primeiro Acesso!           " +
        "               \r\nCique aqui.                                             ");
            this.Esqueceu_Senha.Click += new System.EventHandler(this.Esqueceu_Senha_Click);
            // 
            // tB_Usuario_Login
            // 
            this.tB_Usuario_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Usuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tB_Usuario_Login.ForeColor = System.Drawing.Color.Black;
            this.tB_Usuario_Login.Location = new System.Drawing.Point(84, 82);
            this.tB_Usuario_Login.Name = "tB_Usuario_Login";
            this.tB_Usuario_Login.Size = new System.Drawing.Size(494, 53);
            this.tB_Usuario_Login.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tB_Usuario_Login, "Informe a sua Matricula.");
            this.tB_Usuario_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Usuario_Login_KeyPress);
            this.tB_Usuario_Login.Leave += new System.EventHandler(this.tB_Usuario_Login_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(243, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // abel_Support_Titulo_Cadastro
            // 
            this.abel_Support_Titulo_Cadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abel_Support_Titulo_Cadastro.AutoSize = true;
            this.abel_Support_Titulo_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.abel_Support_Titulo_Cadastro.ForeColor = System.Drawing.Color.White;
            this.abel_Support_Titulo_Cadastro.Location = new System.Drawing.Point(535, 61);
            this.abel_Support_Titulo_Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.abel_Support_Titulo_Cadastro.Name = "abel_Support_Titulo_Cadastro";
            this.abel_Support_Titulo_Cadastro.Size = new System.Drawing.Size(149, 54);
            this.abel_Support_Titulo_Cadastro.TabIndex = 19;
            this.abel_Support_Titulo_Cadastro.Text = "Assist";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoFaculdade.Properties.Resources.CarTechAssistFormsQRCODE;
            this.pictureBox3.Location = new System.Drawing.Point(775, 489);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "FeedBack \r\n Leia o QR-Code para acessar\r\n o formulário e mostre o quanto gostou d" +
        "o\r\n nosso sistema. Obrigado !");
            // 
            // Ocultar_Senha
            // 
            this.Ocultar_Senha.Image = global::ProjetoFaculdade.Properties.Resources.icons8_visão_30;
            this.Ocultar_Senha.Location = new System.Drawing.Point(604, 183);
            this.Ocultar_Senha.Name = "Ocultar_Senha";
            this.Ocultar_Senha.Size = new System.Drawing.Size(39, 34);
            this.Ocultar_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ocultar_Senha.TabIndex = 21;
            this.Ocultar_Senha.TabStop = false;
            this.Ocultar_Senha.Click += new System.EventHandler(this.Ocultar_Senha_Click);
            // 
            // Mostrar_Senha
            // 
            this.Mostrar_Senha.Image = global::ProjetoFaculdade.Properties.Resources.icons8_ocultar_24;
            this.Mostrar_Senha.Location = new System.Drawing.Point(604, 183);
            this.Mostrar_Senha.Name = "Mostrar_Senha";
            this.Mostrar_Senha.Size = new System.Drawing.Size(40, 34);
            this.Mostrar_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mostrar_Senha.TabIndex = 20;
            this.Mostrar_Senha.TabStop = false;
            this.Mostrar_Senha.Click += new System.EventHandler(this.Mostrar_Senha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoFaculdade.Properties.Resources.icons8_cadeado_2_60;
            this.pictureBox2.Location = new System.Drawing.Point(15, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoFaculdade.Properties.Resources.icons8_usuário_60;
            this.pictureBox1.Location = new System.Drawing.Point(15, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.MButon_Login);
            this.panel1.Controls.Add(this.tB_Usuario_Login);
            this.panel1.Controls.Add(this.Ocultar_Senha);
            this.panel1.Controls.Add(this.tB_Senha_Usuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Esqueceu_Senha);
            this.panel1.Controls.Add(this.Mostrar_Senha);
            this.panel1.Location = new System.Drawing.Point(199, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 320);
            this.panel1.TabIndex = 23;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1009, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.abel_Support_Titulo_Cadastro);
            this.Controls.Add(this.label_Tech_Titulo_Login);
            this.Controls.Add(this.label_Car_Titulo_Login);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 725);
            this.MinimumSize = new System.Drawing.Size(1025, 725);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login -  Car Tech Assist";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tech_Titulo_Login;
        private System.Windows.Forms.Label label_Car_Titulo_Login;
        private MetroFramework.Controls.MetroButton MButon_Login;
        private System.Windows.Forms.TextBox tB_Senha_Usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Esqueceu_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label abel_Support_Titulo_Cadastro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox Mostrar_Senha;
        private System.Windows.Forms.PictureBox Ocultar_Senha;
        public System.Windows.Forms.TextBox tB_Usuario_Login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}

