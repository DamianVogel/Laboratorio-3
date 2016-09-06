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
    public partial class frmMostrarConMenus : Form
    {
        private List<Persona> _listaPersonas;

        public List<Persona> ListaDePersonas 
        {
            get { return this._listaPersonas;}
            set { this._listaPersonas = value;} 
        }
        public frmMostrarConMenus()
        {
            InitializeComponent();
            this._listaPersonas = new List<Persona>();
        }

        private void frmMostrarConMenus_Load(object sender, EventArgs e)
        {
           try
           {
                if(this._listaPersonas != null)
                {
                    foreach (Persona unaPersona in this._listaPersonas)
	                {
		                this.lstLista.Items.Add(unaPersona.ToString());
	                }
                }
                else
                {
                    this.lstLista.Items.Add("No hay Personas Cargadas");
                }
           }
           catch(NullReferenceException ex)
           {
                Exception miExcepcion = new Exception("El objeto no está instanciado!!!-frmMostrarConMenus", ex);
                throw miExcepcion;
           }
           catch
           {
                throw new Exception("Error genérico");
           }

        }

        private void CerrarMostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
