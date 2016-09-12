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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {
            InitializeComponent();
        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {
            
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal changer = (FrmPrincipal)this.Owner;
            changer.miDelegado(this.textBox1.Text);
            
        }
    }
}
