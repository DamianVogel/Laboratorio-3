using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                FrmPrincipal frmInicio = new FrmPrincipal();

                Application.Run(frmInicio);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "error Desconocido");
            }
            }
    }
}
