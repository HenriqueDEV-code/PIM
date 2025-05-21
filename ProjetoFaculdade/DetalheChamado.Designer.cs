namespace ProjetoFaculdade
{
    partial class DetalheChamado
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
            this.tB_id_Chamado_Detalhes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Descricao_Detalhes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_Data_Detalhe = new System.Windows.Forms.TextBox();
            this.CB_Status_Detalhe = new MetroFramework.Controls.MetroComboBox();
            this.CB_Operador_Detalhes = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Salvar_Detalhe = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_id_Chamado_Detalhes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 111);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // tB_id_Chamado_Detalhes
            // 
            this.tB_id_Chamado_Detalhes.BackColor = System.Drawing.Color.White;
            this.tB_id_Chamado_Detalhes.Enabled = false;
            this.tB_id_Chamado_Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_id_Chamado_Detalhes.Location = new System.Drawing.Point(249, 37);
            this.tB_id_Chamado_Detalhes.Margin = new System.Windows.Forms.Padding(4);
            this.tB_id_Chamado_Detalhes.Name = "tB_id_Chamado_Detalhes";
            this.tB_id_Chamado_Detalhes.Size = new System.Drawing.Size(79, 31);
            this.tB_id_Chamado_Detalhes.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número do chamado: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Descricao_Detalhes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 147);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // tB_Descricao_Detalhes
            // 
            this.tB_Descricao_Detalhes.BackColor = System.Drawing.Color.White;
            this.tB_Descricao_Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Descricao_Detalhes.Location = new System.Drawing.Point(226, 20);
            this.tB_Descricao_Detalhes.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Descricao_Detalhes.Multiline = true;
            this.tB_Descricao_Detalhes.Name = "tB_Descricao_Detalhes";
            this.tB_Descricao_Detalhes.ReadOnly = true;
            this.tB_Descricao_Detalhes.Size = new System.Drawing.Size(528, 108);
            this.tB_Descricao_Detalhes.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição do Erro:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_Data_Detalhe);
            this.groupBox3.Controls.Add(this.CB_Status_Detalhe);
            this.groupBox3.Controls.Add(this.CB_Operador_Detalhes);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 161);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // tB_Data_Detalhe
            // 
            this.tB_Data_Detalhe.BackColor = System.Drawing.Color.White;
            this.tB_Data_Detalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_Data_Detalhe.Location = new System.Drawing.Point(592, 24);
            this.tB_Data_Detalhe.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Data_Detalhe.Name = "tB_Data_Detalhe";
            this.tB_Data_Detalhe.Size = new System.Drawing.Size(162, 31);
            this.tB_Data_Detalhe.TabIndex = 31;
            // 
            // CB_Status_Detalhe
            // 
            this.CB_Status_Detalhe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_Status_Detalhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Status_Detalhe.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CB_Status_Detalhe.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.CB_Status_Detalhe.FormattingEnabled = true;
            this.CB_Status_Detalhe.ItemHeight = 23;
            this.CB_Status_Detalhe.Location = new System.Drawing.Point(383, 26);
            this.CB_Status_Detalhe.Name = "CB_Status_Detalhe";
            this.CB_Status_Detalhe.Size = new System.Drawing.Size(134, 29);
            this.CB_Status_Detalhe.Style = MetroFramework.MetroColorStyle.Blue;
            this.CB_Status_Detalhe.StyleManager = null;
            this.CB_Status_Detalhe.TabIndex = 5;
            this.CB_Status_Detalhe.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CB_Operador_Detalhes
            // 
            this.CB_Operador_Detalhes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_Operador_Detalhes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Operador_Detalhes.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CB_Operador_Detalhes.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.CB_Operador_Detalhes.FormattingEnabled = true;
            this.CB_Operador_Detalhes.ItemHeight = 23;
            this.CB_Operador_Detalhes.Location = new System.Drawing.Point(129, 26);
            this.CB_Operador_Detalhes.Name = "CB_Operador_Detalhes";
            this.CB_Operador_Detalhes.Size = new System.Drawing.Size(173, 29);
            this.CB_Operador_Detalhes.Style = MetroFramework.MetroColorStyle.Blue;
            this.CB_Operador_Detalhes.StyleManager = null;
            this.CB_Operador_Detalhes.TabIndex = 4;
            this.CB_Operador_Detalhes.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(523, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(308, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operador";
            // 
            // BT_Salvar_Detalhe
            // 
            this.BT_Salvar_Detalhe.Highlight = false;
            this.BT_Salvar_Detalhe.Location = new System.Drawing.Point(632, 503);
            this.BT_Salvar_Detalhe.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Salvar_Detalhe.Name = "BT_Salvar_Detalhe";
            this.BT_Salvar_Detalhe.Size = new System.Drawing.Size(150, 38);
            this.BT_Salvar_Detalhe.Style = MetroFramework.MetroColorStyle.Blue;
            this.BT_Salvar_Detalhe.StyleManager = null;
            this.BT_Salvar_Detalhe.TabIndex = 35;
            this.BT_Salvar_Detalhe.Text = "&Salvar";
            this.BT_Salvar_Detalhe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.BT_Salvar_Detalhe, "Clique aqui para Salvar as \r\n Informações do chamado ou\r\n use um atalho ALT + S\r\n" +
        "");
            this.BT_Salvar_Detalhe.Click += new System.EventHandler(this.BT_Salvar_Detalhe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "INFORMAÇÕES DO CHAMADO";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação!";
            // 
            // DetalheChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(794, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BT_Salvar_Detalhe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 593);
            this.MinimumSize = new System.Drawing.Size(810, 593);
            this.Name = "DetalheChamado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Chamado";
            this.Load += new System.EventHandler(this.DetalheChamado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tB_id_Chamado_Detalhes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tB_Descricao_Detalhes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox CB_Operador_Detalhes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tB_Data_Detalhe;
        private MetroFramework.Controls.MetroComboBox CB_Status_Detalhe;
        public MetroFramework.Controls.MetroButton BT_Salvar_Detalhe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}