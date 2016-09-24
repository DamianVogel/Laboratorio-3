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
            this.cmbOrdenamiento.Items.Add("Por Horario");
            this.cmbOrdenamiento.Items.Add("Por Legajo");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMedico frmMedico = new FrmMedico();
            frmMedico.ShowDialog(this);
            
            if (frmMedico.DialogResult == DialogResult.OK)
            {
                this.medico.Add(frmMedico.UnMedico);
                
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (this.cmbOrdenamiento.SelectedItem.ToString() == "Por Legajo")
            {
                Medico a = (Medico)sender;
                medico.Sort(a.OrdenarPorHorarioEntrada);
            }
            
            if (this.cmbOrdenamiento.SelectedItem.ToString() == "Por Horario")
            {
                Medico a = (Medico)sender;
                medico.Sort(a.OrdenarPorLegajo);
            }
        
        }
        
            
    
    
    }
}
