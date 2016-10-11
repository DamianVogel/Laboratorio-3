using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public class TextBoxInfoNumero: txtSoloNumeros
    {
        // Declaro una lista de DateTime para guardar l fecha y hora de cada cifra ingresada
        private List<DateTime> _logIngresos;

        public TextBoxInfoNumero()
        {
            // Instancio la lista de DateTime
            this._logIngresos = new List<DateTime>();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Aca va la lógica para escribir en un archivo de texto

            }
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            this._logIngresos.Add(DateTime.Now);

            base.OnKeyPress(e);
        }

    }
}
