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

            this.cmbOrdenamiento.SelectedIndex = 1;

            this.btnModificar.Click -= btnOrdenar_Click;
            this.btnEgreso.Click -= btnEgreso_Click;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMedico frmMedico = new FrmMedico();
            frmMedico.ShowDialog(this);
            
            if (frmMedico.DialogResult == DialogResult.OK)
            {
                this.medico.Add(frmMedico.UnMedico);
                this.lstMedicos.Items.Add(frmMedico.UnMedico);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int seleccion = this.lstMedicos.SelectedIndex;

            Medico medSel = new Medico(this.medico[seleccion].Nombre, this.medico[seleccion].Legajo, this.medico[seleccion].Especialidad);

            FrmMedico formMed = new FrmMedico();

            formMed.txtLegajo.Text = medSel.Legajo;
            formMed.txtNombre.Text = medSel.Nombre;
            formMed.cmbEspecialidad.SelectedIndex = (int)medSel.Especialidad;
           
            formMed.ShowDialog(this);

            if (formMed.DialogResult == DialogResult.OK)
            {

                this.medico.Insert(seleccion, formMed.UnMedico);
                this.medico.RemoveAt(seleccion+1);
                this.lstMedicos.Items.Clear();
                foreach (Medico med in medico)
                {
                    this.lstMedicos.Items.Add(med);            
                }
                
                
            }
        
        
        
        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

            Comparison<Medico> prueba;

            if (this.cmbOrdenamiento.SelectedItem.ToString() == "Por Legajo")
            {

                prueba = new Comparison<Medico>(Medico.OrdenarPorLegajo);
                this.medico.Sort(prueba);

                this.lstMedicos.Items.Clear();

                foreach (Medico med in medico)
                {
                    this.lstMedicos.Items.Add(med);
                }
            }

            if (this.cmbOrdenamiento.SelectedItem.ToString() == "Por Horario")
            {
                prueba = new Comparison<Medico>(Medico.OrdenarPorHorarioEntrada);
                this.medico.Sort(prueba);

                this.lstMedicos.Items.Clear();

                foreach (Medico med in medico)
                {
                    this.lstMedicos.Items.Add(med);
                }


            }





        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {

        }
        
            
    
    
    }
}
