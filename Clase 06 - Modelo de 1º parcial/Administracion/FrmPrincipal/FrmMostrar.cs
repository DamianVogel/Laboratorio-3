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
    public partial class FrmMostrar : Form
    {
        
        
        public FrmMostrar()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void MostrarDatos(List<Medico> medico, List<MedicoSalida> medicoSalida)
        {
            this.listSalida.Items.Clear();
            this.lstTrabajando.Items.Clear();
            
            
            
            foreach (Medico med in medico)
            {
                this.lstTrabajando.Items.Add(med);
            }

            foreach (MedicoSalida medSal in medicoSalida)
            {
                this.listSalida.Items.Add(medSal);
            }

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

            FrmPrincipal owner = (FrmPrincipal)this.Owner;

            owner.miDelegado = this.MostrarDatos;
        }
    


    }
}
