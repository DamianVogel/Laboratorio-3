using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados_Ejercicios_Aplicacion01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
                  
         try   {             
            FrmPrincipal frmInicio = new FrmPrincipal();  
            Application.Run(frmInicio);                  
            Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
            }
            
            catch (Exception ex)      
                    {             MessageBox.Show("Error: " + ex.Message, "Error  desconicido");      }          
                
                    finally {      }



         }
    }
}
