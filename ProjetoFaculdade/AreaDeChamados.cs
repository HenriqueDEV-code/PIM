using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFaculdade
{
    public partial class AreaDeChamados : Form
    {
        public AreaDeChamados()
        {
            InitializeComponent();
        }

        private void MButton_Cadastro_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios cadastro = new FormCadastroFuncionarios();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }
    }
}
