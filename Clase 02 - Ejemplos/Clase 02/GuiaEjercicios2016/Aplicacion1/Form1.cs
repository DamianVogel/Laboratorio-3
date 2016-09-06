using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btn1_Click(object sender, EventArgs e)
        {           
            int numero;

            if (Int32.TryParse(this.txtNumero.Text, out numero))
            {


                for (int i = 1; i <= 10; i++)
                {
                    this.lstNumeros.Items.Add(numero + " * " + i + " = " + numero * i);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número en el cuadro de texto");

                this.txtNumero.Focus();

            }
        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = "";
            this.lstNumeros.Items.Clear();

            this.txtNumero.Focus();
        }

        private void lstNumeros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No no");

            this.txtNumero.Focus();

        }     
         
        
    }
}
