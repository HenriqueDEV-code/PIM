namespace ProjetoFaculdade
{
    partial class AreaDeChamados
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
            this.MButton_Cadastro = new MetroFramework.Controls.MetroButton();
            this.LB_Nome_Oper = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Pesquisar_Id_Chamado = new MetroFramework.Controls.MetroButton();
            this.BT_Atualizar_Tabela_Oper = new MetroFramework.Controls.MetroButton();
            this.BT_Novo_Chamado_Oper = new MetroFramework.Controls.MetroButton();
            this.tB_id_Chamado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Oper = new System.Windows.Forms.DataGridView();
            this.label_BemVindo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oper)).BeginInit();
            this.SuspendLayout();
            // 
            // MButton_Cadastro
            // 
            this.MButton_Cadastro.Highlight = false;
            this.MButton_Cadastro.Location = new System.Drawing.Point(554, 27);
            this.MButton_Cadastro.Name = "MButton_Cadastro";
            this.MButton_Cadastro.Size = new System.Drawing.Size(132, 57);
            this.MButton_Cadastro.Style = MetroFramework.MetroColorStyle.Blue;
            this.MButton_Cadastro.StyleManager = null;
            this.MButton_Cadastro.TabIndex = 17;
            this.MButton_Cadastro.Text = "&Cadastrar";
            this.MButton_Cadastro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.MButton_Cadastro, "Clique aqui para abrir uma nova janela para \r\n cadastrar novo usuário ou\r\n use um" +
        " atalho ALT + C");
            this.MButton_Cadastro.Click += new System.EventHandler(this.MButton_Cadastro_Click);
            // 
            // LB_Nome_Oper
            // 
            this.LB_Nome_Oper.AutoSize = true;
            this.LB_Nome_Oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LB_Nome_Oper.ForeColor = System.Drawing.Color.Yellow;
            this.LB_Nome_Oper.Location = new System.Drawing.Point(181, 6);
            this.LB_Nome_Oper.Name = "LB_Nome_Oper";
            this.LB_Nome_Oper.Size = new System.Drawing.Size(86, 31);
            this.LB_Nome_Oper.TabIndex = 18;
            this.LB_Nome_Oper.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Pesquisar_Id_Chamado);
            this.groupBox1.Controls.Add(this.BT_Atualizar_Tabela_Oper);
            this.groupBox1.Controls.Add(this.BT_Novo_Chamado_Oper);
            this.groupBox1.Controls.Add(this.MButton_Cadastro);
            this.groupBox1.Controls.Add(this.tB_id_Chamado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 111);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // BT_Pesquisar_Id_Chamado
            // 
            this.BT_Pesquisar_Id_Chamado.Highlight = false;
            this.BT_Pesquisar_Id_Chamado.Location = new System.Drawing.Point(424, 27);
            this.BT_Pesquisar_Id_Chamado.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Pesquisar_Id_Chamado.Name = "BT_Pesquisar_Id_Chamado";
            this.BT_Pesquisar_Id_Chamado.Size = new System.Drawing.Size(123, 57);
            this.BT_Pesquisar_Id_Chamado.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Pesquisar_Id_Chamado.StyleManager = null;
            this.BT_Pesquisar_Id_Chamado.TabIndex = 34;
            this.BT_Pesquisar_Id_Chamado.Text = "&Pesquisar";
            this.BT_Pesquisar_Id_Chamado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Pesquisar_Id_Chamado, "Clique aqui para localizar o\r\n ID de chamado ou\r\n use um atalho ALT + P");
            this.BT_Pesquisar_Id_Chamado.Click += new System.EventHandler(this.BT_Pesquisar_Id_Chamado_Click);
            // 
            // BT_Atualizar_Tabela_Oper
            // 
            this.BT_Atualizar_Tabela_Oper.Highlight = false;
            this.BT_Atualizar_Tabela_Oper.Location = new System.Drawing.Point(833, 27);
            this.BT_Atualizar_Tabela_Oper.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Atualizar_Tabela_Oper.Name = "BT_Atualizar_Tabela_Oper";
            this.BT_Atualizar_Tabela_Oper.Size = new System.Drawing.Size(132, 57);
            this.BT_Atualizar_Tabela_Oper.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Atualizar_Tabela_Oper.StyleManager = null;
            this.BT_Atualizar_Tabela_Oper.TabIndex = 33;
            this.BT_Atualizar_Tabela_Oper.Text = "&Atualizar";
            this.BT_Atualizar_Tabela_Oper.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Atualizar_Tabela_Oper, "Clique aqui para atualizar as tabelas\r\n de chamados ou\r\n use um atalho ALT + A");
            this.BT_Atualizar_Tabela_Oper.Click += new System.EventHandler(this.BT_Atualizar_Tabela_Oper_Click);
            // 
            // BT_Novo_Chamado_Oper
            // 
            this.BT_Novo_Chamado_Oper.Highlight = false;
            this.BT_Novo_Chamado_Oper.Location = new System.Drawing.Point(693, 27);
            this.BT_Novo_Chamado_Oper.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Novo_Chamado_Oper.Name = "BT_Novo_Chamado_Oper";
            this.BT_Novo_Chamado_Oper.Size = new System.Drawing.Size(132, 57);
            this.BT_Novo_Chamado_Oper.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Novo_Chamado_Oper.StyleManager = null;
            this.BT_Novo_Chamado_Oper.TabIndex = 32;
            this.BT_Novo_Chamado_Oper.Text = "+ &Novo chamado";
            this.BT_Novo_Chamado_Oper.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Novo_Chamado_Oper, "Clique aqui para abrir uma nova janela criar\r\n novo chamado ou\r\n use um atalho AL" +
        "T + N");
            this.BT_Novo_Chamado_Oper.Click += new System.EventHandler(this.BT_Novo_Chamado_Oper_Click);
            // 
            // tB_id_Chamado
            // 
            this.tB_id_Chamado.BackColor = System.Drawing.Color.White;
            this.tB_id_Chamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_id_Chamado.Location = new System.Drawing.Point(312, 38);
            this.tB_id_Chamado.Margin = new System.Windows.Forms.Padding(4);
            this.tB_id_Chamado.Name = "tB_id_Chamado";
            this.tB_id_Chamado.Size = new System.Drawing.Size(79, 31);
            this.tB_id_Chamado.TabIndex = 30;
            this.tB_id_Chamado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_id_Chamado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquise o ID do chamado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "LISTA DE CHAMADOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Oper);
            this.groupBox2.Location = new System.Drawing.Point(18, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 342);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_Oper
            // 
            this.dataGridView_Oper.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Oper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Oper.EnableHeadersVisualStyles = false;
            this.dataGridView_Oper.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView_Oper.Location = new System.Drawing.Point(1, 7);
            this.dataGridView_Oper.Name = "dataGridView_Oper";
            this.dataGridView_Oper.Size = new System.Drawing.Size(963, 333);
            this.dataGridView_Oper.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGridView_Oper, "Clique em cima para abrir uma\r\n janela de detalhes sobre o chamado.");
            this.dataGridView_Oper.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Oper_CellDoubleClick);
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
            this.label_BemVindo.Location = new System.Drawing.Point(12, 7);
            this.label_BemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BemVindo.Name = "label_BemVindo";
            this.label_BemVindo.Size = new System.Drawing.Size(162, 33);
            this.label_BemVindo.TabIndex = 22;
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
            // AreaDeChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1009, 583);
            this.Controls.Add(this.label_BemVindo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LB_Nome_Oper);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 622);
            this.MinimumSize = new System.Drawing.Size(1025, 622);
            this.Name = "AreaDeChamados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área De Chamados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Oper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton MButton_Cadastro;
        private System.Windows.Forms.Label LB_Nome_Oper;
        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroButton BT_Atualizar_Tabela_Oper;
        public MetroFramework.Controls.MetroButton BT_Novo_Chamado_Oper;
        public System.Windows.Forms.TextBox tB_id_Chamado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Oper;
        public MetroFramework.Controls.MetroButton BT_Pesquisar_Id_Chamado;
        private System.Windows.Forms.Label label_BemVindo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}