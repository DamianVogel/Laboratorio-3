using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public class txtCaracterOculto : TextBox
    {
        private char _caracterOculto;

        public char CaracterOculto
        {
            get { return _caracterOculto; }
            set { _caracterOculto = value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (caracter == this._caracterOculto)
            {
                e.KeyChar = '*';
            }
        }


        
    }
}
