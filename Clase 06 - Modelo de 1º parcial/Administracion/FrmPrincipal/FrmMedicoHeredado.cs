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
    public partial class FrmMedicoHeredado : FrmMedico
    {
        public FrmMedicoHeredado()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.btnAceptar_Click(sender,e);
            
           // this.unMedico = new MedicoSalida(base.unMedico);

           //this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    
        
    
    
    
    }
}
