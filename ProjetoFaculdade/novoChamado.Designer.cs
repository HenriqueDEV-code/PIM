namespace ProjetoFaculdade
{
    partial class novoChamado
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Criar_Chamado = new MetroFramework.Controls.MetroButton();
            this.tB_Informe_Matricula_Client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Descricao_Erro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider_Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Criar_Chamado);
            this.groupBox1.Controls.Add(this.tB_Informe_Matricula_Client);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BT_Criar_Chamado
            // 
            this.BT_Criar_Chamado.Highlight = false;
            this.BT_Criar_Chamado.Location = new System.Drawing.Point(360, 30);
            this.BT_Criar_Chamado.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Criar_Chamado.Name = "BT_Criar_Chamado";
            this.BT_Criar_Chamado.Size = new System.Drawing.Size(162, 40);
            this.BT_Criar_Chamado.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Criar_Chamado.StyleManager = null;
            this.BT_Criar_Chamado.TabIndex = 33;
            this.BT_Criar_Chamado.Text = "&Criar Chamado";
            this.BT_Criar_Chamado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Criar_Chamado, "Para criar o chamado clique aqui ou\r\n use o atalho ALT + C");
            this.BT_Criar_Chamado.Click += new System.EventHandler(this.BT_Criar_Chamado_Click);
            // 
            // tB_Informe_Matricula_Client
            // 
            this.tB_Informe_Matricula_Client.BackColor = System.Drawing.Color.White;
            this.tB_Informe_Matricula_Client.Enabled = false;
            this.tB_Informe_Matricula_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Informe_Matricula_Client.Location = new System.Drawing.Point(175, 37);
            this.tB_Informe_Matricula_Client.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Informe_Matricula_Client.Name = "tB_Informe_Matricula_Client";
            this.tB_Informe_Matricula_Client.Size = new System.Drawing.Size(112, 31);
            this.tB_Informe_Matricula_Client.TabIndex = 30;
            this.tB_Informe_Matricula_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Informe_Matricula_Client_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sua matricula: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Descricao_Erro);
            this.groupBox2.Location = new System.Drawing.Point(8, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tB_Descricao_Erro
            // 
            this.tB_Descricao_Erro.BackColor = System.Drawing.Color.White;
            this.tB_Descricao_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Descricao_Erro.Location = new System.Drawing.Point(5, 14);
            this.tB_Descricao_Erro.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Descricao_Erro.Multiline = true;
            this.tB_Descricao_Erro.Name = "tB_Descricao_Erro";
            this.tB_Descricao_Erro.Size = new System.Drawing.Size(980, 271);
            this.tB_Descricao_Erro.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOVO CHAMADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(14, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "DESCRIÇÃO DO ERRO";
            // 
            // errorProvider_Erro
            // 
            this.errorProvider_Erro.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação!";
            // 
            // novoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1009, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 622);
            this.MinimumSize = new System.Drawing.Size(1025, 622);
            this.Name = "novoChamado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Chamado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroButton BT_Criar_Chamado;
        public System.Windows.Forms.TextBox tB_Informe_Matricula_Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tB_Descricao_Erro;
        private System.Windows.Forms.ErrorProvider errorProvider_Erro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}