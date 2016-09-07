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
    public partial class FrmPrincipal : Form
    {
        
        public delegate void DelegadoString (string cadena);

        public DelegadoString miDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrigen FrmOrigen = new FrmOrigen();
            FrmOrigen.MdiParent = this; 
            FrmOrigen.Show();
        
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestino FrmDestino = new FrmDestino();
            FrmDestino.Show(this);
       
        
        
        }
    }
}
