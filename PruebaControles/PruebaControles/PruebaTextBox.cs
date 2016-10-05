using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaControles
{
    public class PruebaTextBox : System.Windows.Forms.TextBox
    {
        public PruebaTextBox()
        {
            this.BackColor = System.Drawing.Color.CadetBlue;


        }

        public PruebaTextBox(System.Drawing.Color color)
        {
            this.BackColor = color;
        }
    
    }
}
