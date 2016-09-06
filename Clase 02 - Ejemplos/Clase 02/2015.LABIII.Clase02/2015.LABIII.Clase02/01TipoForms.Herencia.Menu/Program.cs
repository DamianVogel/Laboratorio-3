using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _01TipoForms.Herencia.Menu
{
    public enum Ejemplo
    {
        AnchorDocking,
        DocumentOutLine,
        Formularios
    }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CREO UNA INSTANCIA DEL FORMULARIO
            frmInicio frm = new frmInicio();

            //CREO UNA VARIABLE DE TIPO ENUMERACION
            Ejemplo queEjemplo;

            //INDICO LA POSICION EN LA PANTALLA
            frm.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                //INICIO LA APLICACION
                frm.ShowDialog();

                //OBTENGO LA PROPIEDAD
                queEjemplo = frm.Seleccion;

                Form frmAplicacion=null;

                //ELIJO EL FORMULARIO DE INICIO DE LA APLICACION
                switch (queEjemplo)
	            {
		            case Ejemplo.AnchorDocking:
                        frmAplicacion = new frmAnclar();
                        break;
                    case Ejemplo.DocumentOutLine:
                        frmAplicacion = new frmOutLine_esquema();
                        break;
                    case Ejemplo.Formularios:
                        frmAplicacion = new frmMenu();
                        break;
                    default:
                        frmAplicacion = null;
                        break;
	            }

                //INICIO LA APLICACION
                Application.Run(frmAplicacion);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("La aplicación terminó.", "FIN DEL EJEMPLO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
