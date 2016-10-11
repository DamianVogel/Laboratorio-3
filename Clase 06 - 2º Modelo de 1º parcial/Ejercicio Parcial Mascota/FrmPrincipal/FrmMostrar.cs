using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
        }

        private void ActualizarDatos(List<Mascota> lista)
        {
            this.listBox1.Items.Clear();
            
            foreach (Mascota masc in lista)
            {
                this.listBox1.Items.Add(masc);
            
            }
        
        
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado = this.ActualizarDatos;
        
        }
    
    
    
    
    
    
    }
}
