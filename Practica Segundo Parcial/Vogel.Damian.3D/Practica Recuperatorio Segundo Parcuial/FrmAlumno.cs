using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Practica_Recuperatorio_Segundo_Parcuial
{
    public partial class FrmAlumno : Form
    {
        Alumno alumno;
        
        public FrmAlumno()
        {
            InitializeComponent();
        
        }

        public FrmAlumno(Alumno alumno2)
        {
            this.alumno = alumno2;
            InitializeComponent();
        }


        public Alumno Alumno { get {return this.alumno;} }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.alumno = new Alumno(this.txtApellido.Text, this.cmbCurso.SelectedIndex, int.Parse(this.txtLegajo.Text));
            
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            if (this.alumno != null)
            {
                this.txtApellido.Text = this.alumno.Apellido;
                this.txtLegajo.Text = this.alumno.Legajo.ToString();
                this.cmbCurso.Items.Add(this.alumno.Curso.ToString());
            }
        }
    }
}
