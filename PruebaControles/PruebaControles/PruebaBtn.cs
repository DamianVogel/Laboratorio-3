using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaControles
{
    public class PruebaBtn : System.Windows.Forms.Button
    {


        public PruebaBtn()
        {
            this.Click += Cerrar;
        
        }

        private void Cerrar(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");
            PruebaBtn btn = new PruebaBtn();
            
           //Al instanciar un objeto tipo button de este metodo genero un bucle infinito!
          //  btn.Cerrar(sender, e);
        }


    
    
    }
}
