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

namespace Delegados_Ejercicios_Aplicacion01
{
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }
    
    
    //Metodo publico
        public void ActualizarAlumno(Alumno alumno)
        {
            this.txtApellido.Text = alumno.Apellido;
            this.txtDni.Text = alumno.Dni.ToString();
            this.txtFoto.Text = alumno.FotoAlumno;
            this.txtNombre.Text = alumno.Nombre;

            this.pictureBox1.ImageLocation = this.txtFoto.Text;
        
        
        }

        private void FrmDatosAlumno_Load(object sender, EventArgs e)
        {
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado3 = this.ActualizarAlumno;

        }
    
    
    
    
    
    }
}
