using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public partial class FrmOrigen : Form
    {
        public FrmOrigen()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
            FrmPrincipal control = (FrmPrincipal)this.MdiParent;
            if (control.miDelegado != null)
            {
                control.miDelegado(this.txtMensaje.Text);
            }
        }
    }
}
