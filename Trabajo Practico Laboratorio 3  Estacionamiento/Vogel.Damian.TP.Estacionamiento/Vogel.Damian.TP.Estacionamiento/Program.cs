using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vogel.Damian.TP;



namespace Vogel.Damian.TP.Estacionamiento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
       
        try{
            Estacionamiento.FrmPrincipal frmInicio = new FrmPrincipal();
            Application.Run(frmInicio);
            }
            catch(Exception ex)
            {
            MessageBox.Show("Error: " + ex.Message, "Error desconiciodo");
            }

        
        
        
        
        
        }
    }
}
