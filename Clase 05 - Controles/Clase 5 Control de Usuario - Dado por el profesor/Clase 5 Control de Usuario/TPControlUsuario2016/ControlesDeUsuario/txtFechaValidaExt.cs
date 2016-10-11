using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public class txtFechaValidaExt : txtFechaValida
    {

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            int cant = this.TextLength;

            char caracter = e.KeyChar;

            // cantidad maxima de caracteres 10 
            if (cant == 19)
            {
                // si ya hay 10 caracteres solo dejo pasar el caracter backSpace
                if (caracter != (char)8)
                    e.Handled = true;
            }
            else
            {

                switch (this._formatoFecha)
                {
                    case eFormato.FormatoIngles:

                        switch (cant)
	                     {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 5:
                            case 6:
                            case 8:
                            case 9:
                            case 11:
                            case 12:
                            case 14:
                            case 15:
                            case 17:
                            case 18:
                                if (!char.IsNumber(caracter) && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;

                            case 4:
                            case 7:
                                if (caracter != '/' && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;
                            case 13:
                            case 16:
                                if (caracter != ':' && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;
                            case 10:
                                if (!char.IsSeparator(caracter) && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;                                
                          
	                     }                      

                        break;

                    case eFormato.FormatoLatino:

                        switch (cant)
                        {
                            case 0:
                            case 1:
                            case 3:
                            case 4:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            case 11:                            
                            case 14:                            
                            case 17:
                            case 18:
                                if (!char.IsNumber(caracter) && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;

                            case 2:
                            case 5:
                                if (caracter != '/' && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;                           
                            case 10:
                                if (!char.IsSeparator(caracter) && !char.IsControl(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;
                            case 12:
                            case 13:
                            case 15:
                            case 16:
                                if (caracter != ':' && !char.IsControl(caracter) && !char.IsNumber(caracter))
                                {
                                    e.Handled = true;
                                }
                                break;

                        }                      

                        break;
                }
            }
        }

    }
}
