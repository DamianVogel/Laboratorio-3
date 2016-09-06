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
    public partial class frmEmpleado : frmPersona
    {
 
        private Empleado _unEmpleado;
        public Empleado UnEmpleado 
        { 
            get{ return this._unEmpleado;} 
        }

        public frmEmpleado()
        {
            InitializeComponent();
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            this._unEmpleado = new Empleado(base.txtNombre.Text, base.txtApellido.Text, this.TxtLegajo.Text);
            base.btnAceptar_Click(sender, e);
        }

     
    }
}
