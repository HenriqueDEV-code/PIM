namespace ProjetoFaculdade
{
    partial class Localizar
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
            this.Esqueceu_Senha = new System.Windows.Forms.Label();
            this.tB_id_Matricula = new System.Windows.Forms.TextBox();
            this.MBNT_Localizar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Esqueceu_Senha
            // 
            this.Esqueceu_Senha.AutoSize = true;
            this.Esqueceu_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Esqueceu_Senha.ForeColor = System.Drawing.Color.White;
            this.Esqueceu_Senha.Location = new System.Drawing.Point(12, 71);
            this.Esqueceu_Senha.Name = "Esqueceu_Senha";
            this.Esqueceu_Senha.Size = new System.Drawing.Size(106, 25);
            this.Esqueceu_Senha.TabIndex = 15;
            this.Esqueceu_Senha.Text = "Matricula:";
            // 
            // tB_id_Matricula
            // 
            this.tB_id_Matricula.BackColor = System.Drawing.Color.White;
            this.tB_id_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tB_id_Matricula.Location = new System.Drawing.Point(115, 65);
            this.tB_id_Matricula.Margin = new System.Windows.Forms.Padding(4);
            this.tB_id_Matricula.Name = "tB_id_Matricula";
            this.tB_id_Matricula.ReadOnly = true;
            this.tB_id_Matricula.Size = new System.Drawing.Size(207, 31);
            this.tB_id_Matricula.TabIndex = 29;
            // 
            // MBNT_Localizar
            // 
            this.MBNT_Localizar.Highlight = false;
            this.MBNT_Localizar.Location = new System.Drawing.Point(329, 130);
            this.MBNT_Localizar.Margin = new System.Windows.Forms.Padding(4);
            this.MBNT_Localizar.Name = "MBNT_Localizar";
            this.MBNT_Localizar.Size = new System.Drawing.Size(114, 36);
            this.MBNT_Localizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.MBNT_Localizar.StyleManager = null;
            this.MBNT_Localizar.TabIndex = 30;
            this.MBNT_Localizar.Text = "Localizar Usuário";
            this.MBNT_Localizar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(456, 179);
            this.Controls.Add(this.MBNT_Localizar);
            this.Controls.Add(this.tB_id_Matricula);
            this.Controls.Add(this.Esqueceu_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(472, 218);
            this.MinimumSize = new System.Drawing.Size(472, 218);
            this.Name = "Localizar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Esqueceu_Senha;
        public System.Windows.Forms.TextBox tB_id_Matricula;
        private MetroFramework.Controls.MetroButton MBNT_Localizar;
    }
}