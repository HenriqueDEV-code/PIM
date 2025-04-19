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
    public partial class EsquecerSenha : Form
    {
        public EsquecerSenha()
        {
            InitializeComponent();
        }

        private void MBNT_Verificar_Click(object sender, EventArgs e)
        {

            /* Add uma verificação para liberar acesso */
            label_Senha_Temp.Visible = true;
            label_Senha.Visible = true;
            label_Senha_Confirm.Visible = true;
            tB_Senha_Temp.Visible = true;
            tB_New_Senha.Visible = true;
            tB_Confir_New_Senha.Visible = true;
            BnT_Verificar_Senha_Temp.Visible = true;



        }
    }
}
