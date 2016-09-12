using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados_Ejercicios_Aplicacion01
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string texto)
        {
            this.label1.Text = texto;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            FrmPrincipal owner = (FrmPrincipal)this.Owner;
            owner.miDelegado = this.ActualizarNombre;
        
        }
    
    
    
    
    
    }
}
