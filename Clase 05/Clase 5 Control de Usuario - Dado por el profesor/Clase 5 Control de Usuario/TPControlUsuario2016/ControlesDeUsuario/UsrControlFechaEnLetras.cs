using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public partial class UsrControlFechaEnLetras : UserControl
    {
        private string _fecha;

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        
        public UsrControlFechaEnLetras()
        {
            InitializeComponent();
        }

        private void UsrControlFechaEnLetras_Load(object sender, EventArgs e)
        {

        }

       
    }
}
