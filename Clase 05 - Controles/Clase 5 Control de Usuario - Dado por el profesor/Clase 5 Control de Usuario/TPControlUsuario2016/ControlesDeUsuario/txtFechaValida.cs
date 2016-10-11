using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public enum eFormato
    {
        FormatoIngles,
        FormatoLatino
    }

    public class txtFechaValida : TextBox
    {      
        
        protected eFormato _formatoFecha;

        public eFormato FormatoFecha
        {
            get { return _formatoFecha; }
            set { _formatoFecha = value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            
            int cant = this.TextLength;

            char caracter = e.KeyChar;

            // cantidad maxima de caracteres 10 
            if (cant == 10)
            {
                // si ya hay 10 caracteres solo dejo pasar el caracter backSpace
                if(caracter != (char)8)
                e.Handled = true;
            }
            else
            {

                switch (this._formatoFecha)
                {
                    case eFormato.FormatoIngles:

                        if (cant == 4 || cant == 7)
                        {
                            if (caracter != '/' && !char.IsControl(caracter))
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if (!char.IsNumber(caracter) && !char.IsControl(caracter))
                            {
                                e.Handled = true;
                            }
                        }

                        break;
                    case eFormato.FormatoLatino:

                        if (cant == 2 || cant == 5)
                        {
                            if (caracter != '-' && !char.IsControl(caracter))
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if (!char.IsNumber(caracter) && !char.IsControl(caracter))
                            {
                                e.Handled = true;
                            }
                        }

                        break;
                }
            }
        }
    }
}
