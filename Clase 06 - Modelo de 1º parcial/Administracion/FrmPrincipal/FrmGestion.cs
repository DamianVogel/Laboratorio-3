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

                if (this.medico.Count == 1)
                {
                    this.btnModificar.Click += this.btnOrdenar_Click;
                    this.btnEgreso.Click += this.btnEgreso_Click;
                }

                FrmPrincipal owner = (FrmPrincipal)this.Owner;
                owner.miDelegado(this.medico,this.medicoSalida);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            
            int seleccion = this.lstMedicos.SelectedIndex;

            //Medico medSel = new Medico(this.medico[seleccion].Nombre, this.medico[seleccion].Legajo, this.medico[seleccion].Especialidad);
            //medSel.Ingreso = this.medico[seleccion].Ingreso;

            FrmMedico formMed = new FrmMedico();

            formMed.txtLegajo.Text = this.medico[seleccion].Legajo;
            formMed.txtNombre.Text = this.medico[seleccion].Nombre;
            formMed.cmbEspecialidad.SelectedIndex = (int)this.medico[seleccion].Especialidad;
           
            formMed.ShowDialog(this);

            if (formMed.DialogResult == DialogResult.OK)
            {

                Medico medSel = new Medico(formMed.txtNombre.Text, formMed.txtLegajo.Text, (eEspecialidades)formMed.cmbEspecialidad.SelectedIndex);
                medSel.Ingreso = this.medico[seleccion].Ingreso;               
                // this.medico.Insert(seleccion, formMed.UnMedico);
                this.medico.Insert(seleccion, medSel);
                this.medico.RemoveAt(seleccion+1);
                this.lstMedicos.Items.Clear();
                foreach (Medico med in medico)
                {
                    this.lstMedicos.Items.Add(med);            
                }

                this.cmbOrdenamiento_SelectedIndexChanged(sender, e);

                if (this.medico.Count == 0)
                {
                    this.btnEgreso.Click -= this.btnEgreso_Click;
                    this.btnModificar.Click -= this.btnOrdenar_Click;
                }

                FrmPrincipal owner = (FrmPrincipal)this.Owner;
                owner.miDelegado(this.medico,this.medicoSalida);

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
           
            int seleccion = this.lstMedicos.SelectedIndex;

            
            MedicoSalida medAuxSalida = new MedicoSalida(this.medico[seleccion]);
            medAuxSalida.Ingreso = this.medico[seleccion].Ingreso;
            


            FrmMedicoHeredado frmMedHeredado = new FrmMedicoHeredado();
            frmMedHeredado.txtLegajo.Text = this.medico[seleccion].Legajo;
            frmMedHeredado.txtNombre.Text = this.medico[seleccion].Nombre;
            frmMedHeredado.cmbEspecialidad.SelectedIndex = (int)this.medico[seleccion].Especialidad;
            
            frmMedHeredado.txtSueldo.Text = medAuxSalida.Salario.ToString();

            foreach (Control text in frmMedHeredado.Controls)
            {
                if (text is TextBox)
                {
                    TextBox txt = (TextBox)text;
                    txt.ReadOnly = true;
                }

            }
            
            
            
            
            frmMedHeredado.ShowDialog(this);

            if (frmMedHeredado.DialogResult == DialogResult.OK)
            {
                this.medicoSalida.Add(medAuxSalida);

                this.medico.RemoveAt(seleccion);
                this.lstMedicos.Items.Clear();
                foreach (Medico med in medico)
                {
                    this.lstMedicos.Items.Add(med);
                }

                this.cmbOrdenamiento_SelectedIndexChanged(sender, e);
               
                if (this.medico.Count == 0)
                {
                    this.btnEgreso.Click -= this.btnEgreso_Click;
                    this.btnModificar.Click -= this.btnOrdenar_Click;
                }

                FrmPrincipal owner = (FrmPrincipal)this.Owner;
                owner.miDelegado(this.medico,this.medicoSalida);
            
            }
        }
        
            
    
    
    }
}
