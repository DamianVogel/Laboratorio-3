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

namespace Eventos.WindowsForm
{
    public partial class frmEmpleados : Form
    {
        private Empleado _miEmpleado;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        //Manejadores estáticos

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.CargarCombo();

        }

        
        private void CargarCombo()
        {
            foreach (TipoManejador item in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(item);
            }
            
        }




    }
}
