using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01TipoForms.Herencia.Menu
{
    public partial class frmInicio : Form
    {
        private Ejemplo _seleccion;

        public Ejemplo Seleccion 
        {
            get { return this._seleccion; }
        }

        public frmInicio()
        {
            InitializeComponent();
            //NECESITO UTILIZAR EL METODO GETVALUES PARA OBTENER UN ARRAY
            //Y ASI PODER RECORRERLO CON UN FOREACH
            foreach (Ejemplo elementoEnumerado in Enum.GetValues(typeof(Ejemplo)))
	        {
		        this.cboEjemplos.Items.Add(elementoEnumerado);
	        }

        }

        private void cboEjemplos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CREO UNA VARIABLE DE TIPO ENUMERACION
            Ejemplo miEjemplo;

            miEjemplo = (Ejemplo)Enum.Parse(typeof(Ejemplo),this.cboEjemplos.SelectedItem.ToString());

            this._seleccion = miEjemplo;

            //CIERRO EL FORMULARIO DE INICIO
            this.Close();
        }
    }
}
