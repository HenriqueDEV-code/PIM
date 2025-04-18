﻿namespace ProjetoFaculdade
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Senha_Usuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Esqueceu_Senha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_Usuario_Login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abel_Support_Titulo_Cadastro = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Tech_Titulo_Login
            // 
            this.label_Tech_Titulo_Login.AutoSize = true;
            this.label_Tech_Titulo_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label_Tech_Titulo_Login.ForeColor = System.Drawing.Color.Yellow;
            this.label_Tech_Titulo_Login.Location = new System.Drawing.Point(339, 22);
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
            this.label_Car_Titulo_Login.Location = new System.Drawing.Point(245, 22);
            this.label_Car_Titulo_Login.Name = "label_Car_Titulo_Login";
            this.label_Car_Titulo_Login.Size = new System.Drawing.Size(99, 54);
            this.label_Car_Titulo_Login.TabIndex = 7;
            this.label_Car_Titulo_Login.Text = "Car";
            this.label_Car_Titulo_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MButon_Login
            // 
            this.MButon_Login.Highlight = false;
            this.MButon_Login.Location = new System.Drawing.Point(605, 439);
            this.MButon_Login.Name = "MButon_Login";
            this.MButon_Login.Size = new System.Drawing.Size(140, 48);
            this.MButon_Login.Style = MetroFramework.MetroColorStyle.Blue;
            this.MButon_Login.StyleManager = null;
            this.MButon_Login.TabIndex = 17;
            this.MButon_Login.Text = "Login";
            this.MButon_Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MButon_Login.Click += new System.EventHandler(this.MButon_Login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Senha_Usuario);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(140, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 79);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // tB_Senha_Usuario
            // 
            this.tB_Senha_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tB_Senha_Usuario.Location = new System.Drawing.Point(74, 17);
            this.tB_Senha_Usuario.Name = "tB_Senha_Usuario";
            this.tB_Senha_Usuario.PasswordChar = '*';
            this.tB_Senha_Usuario.Size = new System.Drawing.Size(524, 53);
            this.tB_Senha_Usuario.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tB_Senha_Usuario, "Digite a sua senha.");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoFaculdade.Properties.Resources.icons8_cadeado_2_60;
            this.pictureBox2.Location = new System.Drawing.Point(6, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Esqueceu_Senha
            // 
            this.Esqueceu_Senha.AutoSize = true;
            this.Esqueceu_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Esqueceu_Senha.ForeColor = System.Drawing.Color.White;
            this.Esqueceu_Senha.Location = new System.Drawing.Point(135, 462);
            this.Esqueceu_Senha.Name = "Esqueceu_Senha";
            this.Esqueceu_Senha.Size = new System.Drawing.Size(203, 25);
            this.Esqueceu_Senha.TabIndex = 14;
            this.Esqueceu_Senha.Text = "Esqueceu a senha?";
            this.toolTip1.SetToolTip(this.Esqueceu_Senha, "Esqueceu Senha ou                             \r\nÉ seu primeiro Acesso!           " +
        "               \r\nCique aqui.                                             ");
            this.Esqueceu_Senha.Click += new System.EventHandler(this.Esqueceu_Senha_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Usuario_Login);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(140, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tB_Usuario_Login
            // 
            this.tB_Usuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tB_Usuario_Login.Location = new System.Drawing.Point(75, 17);
            this.tB_Usuario_Login.Name = "tB_Usuario_Login";
            this.tB_Usuario_Login.Size = new System.Drawing.Size(524, 53);
            this.tB_Usuario_Login.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tB_Usuario_Login, "Digite a sua Matricula.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoFaculdade.Properties.Resources.icons8_usuário_60;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 162);
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
            this.abel_Support_Titulo_Cadastro.Location = new System.Drawing.Point(467, 22);
            this.abel_Support_Titulo_Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.abel_Support_Titulo_Cadastro.Name = "abel_Support_Titulo_Cadastro";
            this.abel_Support_Titulo_Cadastro.Size = new System.Drawing.Size(149, 54);
            this.abel_Support_Titulo_Cadastro.TabIndex = 19;
            this.abel_Support_Titulo_Cadastro.Text = "Assist";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informção!";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 589);
            this.Controls.Add(this.abel_Support_Titulo_Cadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Esqueceu_Senha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MButon_Login);
            this.Controls.Add(this.label_Tech_Titulo_Login);
            this.Controls.Add(this.label_Car_Titulo_Login);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 628);
            this.MinimumSize = new System.Drawing.Size(900, 628);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Tech_Titulo_Login;
        private System.Windows.Forms.Label label_Car_Titulo_Login;
        private MetroFramework.Controls.MetroButton MButon_Login;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_Senha_Usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Esqueceu_Senha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_Usuario_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label abel_Support_Titulo_Cadastro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

