using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtCadena.Text;
            string cadenaRev = "";
            
            
            for (int i = 0; i < cadena.Length; i++)
            {
                
                cadenaRev = String.Concat(cadenaRev, cadena.Substring(((cadena.Length-1)-i),1));
            }

            this.txtInvertida.Text = cadenaRev;

            

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtInvertida.ReadOnly = true;
            this.txtAlfabetico.ReadOnly = true;
        
        }

        public static string OrdenarCadena (string a)
        {
                  
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (char.Parse(a.Substring(i, 1)) > char.Parse(a.Substring(j, 1)))
                    {
                            string c = a.Substring(i, 1);
                            a.Insert(i, a.Substring(j, 1).ToString());
                            a.Insert(j,c);
                    }

                    
                              
                }           
            }
            //PROBAR ESTE METODO!
            return a;     
        }
       
    }
}
