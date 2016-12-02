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


namespace Canuto.SegundoParcial.LabIII
{
    public partial class FrmAvion : Form
    {

        private Entidades.Canuto canuto;
        
        
        public FrmAvion()
        {
            InitializeComponent();
        }

        public FrmAvion(Entidades.Canuto canutitoCons)
        {
            InitializeComponent();
            this.canuto = canutitoCons;
        
        }




        public Entidades.Canuto Canuto { get { return this.canuto; } }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.canuto = new Entidades.Canuto(int.Parse(this.txtId.Text), this.txtNombre.Text, this.txtApellido.Text, double.Parse(this.txtDolares.Text), this.cbmEscondite.SelectedIndex);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void FrmAvion_Load(object sender, EventArgs e)
        {
            if (canuto != null)
            {
                this.txtId.Text = canuto.Id.ToString();
                this.txtApellido.Text = canuto.Apellido;
                this.txtDolares.Text = canuto.Dolares.ToString();
                this.txtNombre.Text = canuto.Nombre;
                this.cbmEscondite.SelectedIndex = canuto.CodEscondite;            
            
            }
        }
    
    
        
    
    
    
    
    }
}
