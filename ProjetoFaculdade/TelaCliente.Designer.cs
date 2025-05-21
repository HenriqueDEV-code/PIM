namespace ProjetoFaculdade
{
    partial class TelaCliente
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
            this.LB_Nome_Cliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Atualizar_Tabela = new MetroFramework.Controls.MetroButton();
            this.BT_Novo_Chamado = new MetroFramework.Controls.MetroButton();
            this.tB_Exibe_Maticula_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label_BemVindo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Nome_Cliente
            // 
            this.LB_Nome_Cliente.AutoSize = true;
            this.LB_Nome_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LB_Nome_Cliente.ForeColor = System.Drawing.Color.Yellow;
            this.LB_Nome_Cliente.Location = new System.Drawing.Point(176, 6);
            this.LB_Nome_Cliente.Name = "LB_Nome_Cliente";
            this.LB_Nome_Cliente.Size = new System.Drawing.Size(86, 31);
            this.LB_Nome_Cliente.TabIndex = 0;
            this.LB_Nome_Cliente.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Atualizar_Tabela);
            this.groupBox1.Controls.Add(this.BT_Novo_Chamado);
            this.groupBox1.Controls.Add(this.tB_Exibe_Maticula_Cliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BT_Atualizar_Tabela
            // 
            this.BT_Atualizar_Tabela.Highlight = false;
            this.BT_Atualizar_Tabela.Location = new System.Drawing.Point(812, 26);
            this.BT_Atualizar_Tabela.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Atualizar_Tabela.Name = "BT_Atualizar_Tabela";
            this.BT_Atualizar_Tabela.Size = new System.Drawing.Size(164, 61);
            this.BT_Atualizar_Tabela.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Atualizar_Tabela.StyleManager = null;
            this.BT_Atualizar_Tabela.TabIndex = 3;
            this.BT_Atualizar_Tabela.Text = "&Atualizar";
            this.BT_Atualizar_Tabela.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Atualizar_Tabela, "Clique aqui para atualizar as tabelas\r\n de chamados ou\r\n use um atalho ALT + A\r\n");
            this.BT_Atualizar_Tabela.Click += new System.EventHandler(this.BT_Atualizar_Tabela_Click);
            // 
            // BT_Novo_Chamado
            // 
            this.BT_Novo_Chamado.Highlight = false;
            this.BT_Novo_Chamado.Location = new System.Drawing.Point(630, 26);
            this.BT_Novo_Chamado.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Novo_Chamado.Name = "BT_Novo_Chamado";
            this.BT_Novo_Chamado.Size = new System.Drawing.Size(164, 61);
            this.BT_Novo_Chamado.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Novo_Chamado.StyleManager = null;
            this.BT_Novo_Chamado.TabIndex = 2;
            this.BT_Novo_Chamado.Text = "+ &Novo chamado";
            this.BT_Novo_Chamado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Novo_Chamado, "Clique aqui para abrir uma nova janela criar\r\n novo chamado ou\r\n use um atalho AL" +
        "T + N\r\n");
            this.BT_Novo_Chamado.Click += new System.EventHandler(this.BT_Novo_Chamado_Click);
            // 
            // tB_Exibe_Maticula_Cliente
            // 
            this.tB_Exibe_Maticula_Cliente.BackColor = System.Drawing.Color.White;
            this.tB_Exibe_Maticula_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Exibe_Maticula_Cliente.Location = new System.Drawing.Point(186, 37);
            this.tB_Exibe_Maticula_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Exibe_Maticula_Cliente.Name = "tB_Exibe_Maticula_Cliente";
            this.tB_Exibe_Maticula_Cliente.Size = new System.Drawing.Size(90, 31);
            this.tB_Exibe_Maticula_Cliente.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.dataGridView_Cliente);
            this.groupBox2.Location = new System.Drawing.Point(17, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(1, 7);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.Size = new System.Drawing.Size(963, 333);
            this.dataGridView_Cliente.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "LISTA DE CHAMADOS";
            // 
            // label_BemVindo
            // 
            this.label_BemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_BemVindo.AutoSize = true;
            this.label_BemVindo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_BemVindo.ForeColor = System.Drawing.Color.White;
            this.label_BemVindo.Location = new System.Drawing.Point(7, 6);
            this.label_BemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BemVindo.Name = "label_BemVindo";
            this.label_BemVindo.Size = new System.Drawing.Size(162, 33);
            this.label_BemVindo.TabIndex = 23;
            this.label_BemVindo.Text = "Bem Vindo: ";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação!";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1009, 583);
            this.Controls.Add(this.label_BemVindo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LB_Nome_Cliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 622);
            this.MinimumSize = new System.Drawing.Size(1025, 622);
            this.Name = "TelaCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Nome_Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tB_Exibe_Maticula_Cliente;
        public MetroFramework.Controls.MetroButton BT_Novo_Chamado;
        public MetroFramework.Controls.MetroButton BT_Atualizar_Tabela;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_BemVindo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}