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
    public partial class FrmPrincipal : Form
    {
        public delegate void DelegadoLista(List<Medico> a, List<MedicoSalida> b);

        public DelegadoLista miDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion frmGestion = new FrmGestion();
            frmGestion.ShowDialog(this); //De forma modal

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();
            frmMostrar.Show(this);
        
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Realmente quiere salir de esta aplicacion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;

        }
    
    }//Fin de la clase
}
