using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MisControles
{
    public class PruebaFinal: System.Windows.Forms.TextBox
    {
        public PruebaFinal()
        {
            this.BackColor = System.Drawing.Color.Blue;        
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.A)
            {
                e.Handled = true;
                MessageBox.Show("Es la letra");
            }
            
            
            base.OnKeyPress(e);
        }


    }
}
