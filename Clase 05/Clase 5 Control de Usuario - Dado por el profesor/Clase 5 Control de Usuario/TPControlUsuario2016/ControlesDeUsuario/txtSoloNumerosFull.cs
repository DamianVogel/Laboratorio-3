using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ControlesDeUsuario
{
    public enum eTipoDato
    {
        Entero,
        Doble,
        Binario,
        Octal,
        Hexadecimal
    }

    public class txtSoloNumerosFull: TextBox
    {
                
        private eTipoDato _tipo;        

        // para poder agregar los decoradores debo primero agregar el usind de componentModel
        [Category("Datos")]
        [Description ("Tipo de filtro que tendrá el control")]
        public eTipoDato TipoDeDato
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // guardo en la variable caracter el caracter presionado
            char caracter = e.KeyChar;

            switch (this._tipo)
            {
                case eTipoDato.Entero:
                    // dejo pasar solo los números y el carácter backSpace
                    if (!char.IsDigit(caracter) && !char.IsControl(caracter))
                        e.Handled = true;
                    break;

                case eTipoDato.Doble:
                    // dejo pasar solo los números, el carácter backSpace y el punto
                    if (!char.IsDigit(caracter) && !char.IsControl(caracter) && caracter != '.')
                        e.Handled = true;
                    break;

                case eTipoDato.Binario:
                    // dejo pasar solo los números 0, 1 y el caracter backSpace
                    if (caracter != '1' && caracter != '0' && !char.IsControl(caracter))
                        e.Handled = true;
                    break;

                case eTipoDato.Octal:
                    // dejo pasar solo los números del 0 al 8 y el caracter backSpace
                    if ( !(caracter >= '0' && caracter <= '8') && !char.IsControl(caracter))
                        e.Handled = true;
                    break;

                case eTipoDato.Hexadecimal:
                    // Si el caracter presionado es una letra. la paso a mayúsculas
                    if (char.IsLetter(caracter))
                    {
                        // lo paso a mayúsculas
                        caracter = char.ToUpper(caracter);
                        // para que se escriba en mayúscular piso tambien e.Keychar
                        e.KeyChar = char.ToUpper(caracter);
                    }
                    // si el caracter presionado no es un número del 0 al 9, backSpace o una letra entre A y F
                    if (!char.IsDigit(caracter) && !char.IsControl(caracter) && !(caracter >= 'A' && caracter <= 'F'))
                        // manejo el evento y no se escribe nada en el textBox
                        e.Handled = true;                   
                    break;                
            }                  
        } 
    }
}
