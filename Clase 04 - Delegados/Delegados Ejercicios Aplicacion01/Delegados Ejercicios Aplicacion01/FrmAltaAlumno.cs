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
using System.IO;

namespace Delegados_Ejercicios_Aplicacion01
{
    public partial class FrmAltaAlumno : Form
    {
        private Alumno alumno;
        
        
        public FrmAltaAlumno()
        {
            InitializeComponent();
        
        }





        private void AltaAlumno(object sender, EventArgs e)
        {
            alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), this.txtFoto.Text);

            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado3(alumno);
        
            
        
        
        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += AltaAlumno;
            this.DoubleClick += DobleClick;
        }

        private void DobleClick(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = this.openFileDialog1.FileName;
                string dir = Path.GetFullPath(file);

                this.txtFoto.Text = dir;

            }
        
        
        }




    }
}
