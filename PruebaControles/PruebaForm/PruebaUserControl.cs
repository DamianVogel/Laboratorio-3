using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForm
{
    public partial class PruebaUserControl : UserControl
    {
        private ErrorProvider errorProv;
        
        public PruebaUserControl()
        {
            InitializeComponent();

            this.textBox1.Validating += this.validando;
      
        }

        public void validando(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.textBox1.Text))
            {

                e.Cancel = true;
                
                //MessageBox.Show("hola");
                errorProv = new ErrorProvider();
                
                errorProv.SetError((Control)sender, "probando");
                errorProv.BlinkRate = 500;
                errorProv.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            
            }
            else
                MessageBox.Show("Va como piña");

        }

        public void valido(object sender, EventArgs e)
        { 
            
        
        }
    
    
    
    }
}
