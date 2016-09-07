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
    public partial class FrmDestino : Form
    {
        public FrmDestino()
        {
            InitializeComponent();
        }



        private void MostrarMensaje(string Mensaje)
        {
            this.lblMensaje.Text = Mensaje;      
        }

        private void FrmDestino_Load(object sender, EventArgs e)
        {
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado = this.MostrarMensaje;
        
        
          

        }

        
    
    }
}
