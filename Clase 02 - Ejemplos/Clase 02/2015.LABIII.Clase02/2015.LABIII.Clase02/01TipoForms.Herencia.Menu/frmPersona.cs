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
    public partial class frmPersona : Form
    {
        private Persona _unaPersona;
        public Persona UnaPersona 
        {
            get { return this._unaPersona; }
        }
        public frmPersona()
        {
            InitializeComponent();
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this._unaPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
