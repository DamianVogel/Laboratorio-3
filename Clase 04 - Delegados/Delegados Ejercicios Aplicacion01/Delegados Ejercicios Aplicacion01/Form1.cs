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
   
    
    public partial class FrmPrincipal : Form
    {
        public delegate void Delegado(string a);

        public delegate void DelegadoAlumno(Alumno alumno);

        public Delegado miDelegado;

        public Delegado miDelegado2;

        public DelegadoAlumno miDelegado3;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frmTest = new frmTestDelegados();
            frmTest.Show(this);
            this.StartPosition = FormStartPosition.CenterParent;
        
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosAlumno formAlumno = new FrmDatosAlumno();
            formAlumno.Show(this);

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno formAltaAlumno = new FrmAltaAlumno();
            formAltaAlumno.Show(this);

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.Show(this);


        }

    } 








}
