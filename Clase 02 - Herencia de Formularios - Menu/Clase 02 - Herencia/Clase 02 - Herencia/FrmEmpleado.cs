using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_02___Herencia
{
    public partial class FrmEmpleado : FrmPersona
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chau");
        }
    }
}
