using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vogel.Damian;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
            this.Text ="frmAlumno";

        
            
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    
        
    
    
    }

    



}
