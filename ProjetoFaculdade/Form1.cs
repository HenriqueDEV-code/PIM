



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
    public partial class FormLogin: Form
    {

       
        public FormLogin()
        {
            InitializeComponent();

            
        }

        

       

        private void MButon_Login_Click(object sender, EventArgs e)
        {

            /* Criar o codigo de verificação antes de acessar */
            AreaDeChamados Chamados = new AreaDeChamados();
            this.Hide();
            Chamados.ShowDialog();
            this.Show();
        }

        private void Esqueceu_Senha_Click(object sender, EventArgs e)
        {
            EsquecerSenha Senhas = new EsquecerSenha();
            Senhas.ShowDialog();
            this.Show();
        }
    }
}
