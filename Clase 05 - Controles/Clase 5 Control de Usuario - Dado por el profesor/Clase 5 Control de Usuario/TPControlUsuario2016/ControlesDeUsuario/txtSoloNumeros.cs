using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlesDeUsuario
{
    public class txtSoloNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            char charTecleado = e.KeyChar;
          if( (!char.IsDigit(charTecleado) && !char.IsControl(charTecleado) && !char.IsSeparator(charTecleado)))
          {
              e.Handled = true;
          }
          
        }

    }
}
