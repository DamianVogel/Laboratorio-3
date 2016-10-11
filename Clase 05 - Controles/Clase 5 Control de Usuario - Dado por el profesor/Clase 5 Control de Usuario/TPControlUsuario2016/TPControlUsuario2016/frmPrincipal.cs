using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPControlUsuario2016
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            usrAlarma1.TiempoAgotado += usrAlarma1_TiempoAgotado;
        }

        void usrAlarma1_TiempoAgotado(object sender, ControlesDeUsuario.timeUpEventArgs e)
        {
            MessageBox.Show("Se acabo el tiempo", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void controlLogin1_Enter(object sender, EventArgs e)
        {

        }

        private void controlLogin1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
