using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace _01TipoForms.Herencia.Menu
{
    public partial class frmMenu : Form
    {
        private List<Persona> _listaDePersonas;

        public frmMenu()
        {
            InitializeComponent();

            //INICIALIZO EL ATRIBUTO
            this._listaDePersonas = new List<Persona>();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //INDICO QUE VA A SER UN FORM CONTENEDOR
            this.IsMdiContainer = true;
            //MUESTRO EL FORM MAXIMIZADO
            this.WindowState = FormWindowState.Maximized;
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMPERSONA
            frmPersona frmNormal = new frmPersona();

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmNormal.StartPosition = FormStartPosition.CenterScreen;

            //LO MUESTRO EN FORMA 'NORMAL'
            frmNormal.Show();

            //AGREGO UN OBJETO DE TIPO PERSONA A LA LISTA
            _listaDePersonas.Add(frmNormal.UnaPersona);
        }

        private void ContenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMPERSONA
            frmPersona frmContenido = new frmPersona();

            //INDICO QUIEN SERA EL FORMULARIO PADRE
            frmContenido.MdiParent = this;

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmContenido.StartPosition = FormStartPosition.CenterScreen;

            //MUESTRO EL FORMULARIO
            frmContenido.Show();
        }

        private void PropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMPERSONA
            frmPersona frmPropietario = new frmPersona();

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmPropietario.StartPosition = FormStartPosition.CenterScreen;

            //MUESTRO EL FORMULARIO CON SU 'DUEÑO'
            frmPropietario.Show(this);
        }

        private void DialogoOModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMPERSONA
            frmPersona frmDialogo = new frmPersona();

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmDialogo.StartPosition = FormStartPosition.CenterScreen;

            //LO MUESTRO EN FORMA 'MODAL'
            frmDialogo.ShowDialog();

            //AGREGO UN OBJETO DE TIPO PERSONA A LA LISTA
            if(frmDialogo.DialogResult == DialogResult.OK)
            {
                _listaDePersonas.Add(frmDialogo.UnaPersona);
            }

        }

        private void HererdadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMEMPLEADO
            frmEmpleado frmHeredado = new frmEmpleado();

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmHeredado.StartPosition = FormStartPosition.CenterScreen;

            //AGREGO UN OBJETO DE TIPO EMPLEADO A LA LISTA
            if(frmHeredado.ShowDialog() == DialogResult.OK)
            {
                _listaDePersonas.Add(frmHeredado.UnEmpleado);
            }

        }

        private void MostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTANCIO UN OBJETO DE TIPO FRMMOSTRARCONMENUS
            frmMostrarConMenus frmMostrar = new frmMostrarConMenus();

            //INDICO QUIEN SERA EL FORMULARIO PADRE
            frmMostrar.MdiParent = this;

            //INDICO DONDE SE MOSTRARA EL FORMULARIO
            frmMostrar.StartPosition = FormStartPosition.CenterScreen;

            //OCULTO LOS BOTONES PARA CERRAR O MODIFICAR EL TAMAÑO
            //DEL FORMULARIO
            frmMostrar.ControlBox = false;

            if(this._listaDePersonas.Count > 0)
            {
                frmMostrar.ListaDePersonas = this._listaDePersonas;
            }

            //MUESTRO EL FORMULARIO
            frmMostrar.Show();

        }

    }
}
