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
            this.MButton_Cadastro = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MButton_Cadastro
            // 
            this.MButton_Cadastro.Highlight = false;
            this.MButton_Cadastro.Location = new System.Drawing.Point(12, 966);
            this.MButton_Cadastro.Name = "MButton_Cadastro";
            this.MButton_Cadastro.Size = new System.Drawing.Size(147, 63);
            this.MButton_Cadastro.Style = MetroFramework.MetroColorStyle.Blue;
            this.MButton_Cadastro.StyleManager = null;
            this.MButton_Cadastro.TabIndex = 17;
            this.MButton_Cadastro.Text = "Cadastrar";
            this.MButton_Cadastro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MButton_Cadastro.Click += new System.EventHandler(this.MButton_Cadastro_Click);
            // 
            // AreaDeChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MButton_Cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AreaDeChamados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área De Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton MButton_Cadastro;
    }
}