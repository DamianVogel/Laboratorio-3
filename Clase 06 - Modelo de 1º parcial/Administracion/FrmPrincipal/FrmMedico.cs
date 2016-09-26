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
    public partial class FrmMedico : Form
    {
        protected Medico unMedico;
        public Medico UnMedico { get { return this.unMedico; } }
        
        public FrmMedico()
        {
            
            InitializeComponent();
            
            foreach (eEspecialidades elementoEnumerado in Enum.GetValues(typeof(eEspecialidades)))
            {
                this.cmbEspecialidad.Items.Add(elementoEnumerado);
            }
            
            
        
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.unMedico = new Medico(this.txtNombre.Text, this.txtLegajo.Text, (eEspecialidades)this.cmbEspecialidad.SelectedItem);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }
    
        
    
    
    
    }
}
