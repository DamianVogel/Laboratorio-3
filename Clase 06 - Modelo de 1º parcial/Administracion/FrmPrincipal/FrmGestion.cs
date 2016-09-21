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
    public partial class FrmGestion : Form
    {
        protected List<Medico> medico;
        protected List<MedicoSalida> medicoSalida; 
        
        
        
        public FrmGestion()
        {
            InitializeComponent();
            this.medico = new List<Medico>();
            this.medicoSalida = new List<MedicoSalida>();
            
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMedico frmMedico = new FrmMedico();
            frmMedico.ShowDialog(this);
            if (frmMedico.DialogResult == DialogResult.OK)
            {
                //Medico medico;
            }

        }
        
            
    
    
    }
}
