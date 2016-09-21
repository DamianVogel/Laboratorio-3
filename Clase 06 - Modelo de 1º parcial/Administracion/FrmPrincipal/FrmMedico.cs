using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion;

namespace FrmPrincipal
{
    public partial class FrmMedico : Form
    {
        protected Medico unMedico;
        
        public FrmMedico()
        {
            //unMedico = new Medico(this.textBox1, this.textBox2, this.comboBox1);
            this.comboBox1.Items.Add(eEspecialidades.Cardiologo);
            this.comboBox1.Items.Add(eEspecialidades.Clinico);
            this.comboBox1.Items.Add(eEspecialidades.Pediatra);
            
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            
        }
    
        
    
    
    
    }
}
