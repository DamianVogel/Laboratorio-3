using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= this.Informar;
            this.btnAceptar.Click -= this.Calcular;
            this.btnLimpiar.Click += this.Limpiar;
            int acumulador = int.Parse(this.txtCantidadRetirar.Text);
            

            if (acumulador >= 100)
            {
                this.txtBillete100.Text = (acumulador / 100).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete100.Text))*100));
            }

            if (acumulador >= 50)
            {
                this.txtBillete50.Text = (acumulador / 50).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete50.Text)) * 50));
            }
            if (acumulador >= 20)
            {
                this.txtBillete20.Text = (acumulador / 20).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete20.Text)) * 20));
            }
            if (acumulador >= 10)
            {
                this.txtBillete10.Text = (acumulador / 10).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete10.Text)) * 10));
            }
            if (acumulador >= 5)
            {
                this.txtBillete5.Text = (acumulador / 5).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete5.Text)) * 5));
            }
            if (acumulador >= 2)
            {
                int flag=0;
                if (acumulador % 2 == 1)
                {
                    flag = 1;
                
                }
                this.txtBillete2.Text = (acumulador / 2).ToString();
                acumulador = (acumulador - ((int.Parse(this.txtBillete2.Text)) * 2));

                if (flag == 1)
                {
                    MessageBox.Show("Le Queda $1 peso", "Vuelto", MessageBoxButtons.OK);
                }


            }
            else
                MessageBox.Show("Le Queda $1 peso", "Vuelto", MessageBoxButtons.OK);

            this.btnAceptar.Click += this.Informar;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += this.Calcular;
            //this.btnSalir.Click += this.Salir;
        }

        private void Limpiar(object sender, EventArgs e)
        {

            this.btnLimpiar.Click -= this.Limpiar; 
            
            
            
            foreach(Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control t in c.Controls)
                    {
                        if (t is TextBox)
                        {
                            t.Text = "";
                        }
                    
                    }
                
                }
                
            }

            this.btnAceptar.Click += this.Calcular;
            //this.btnSalir.Click += Salir;
        }
            private void Informar (object sender, EventArgs e)    
            {
                MessageBox.Show("Debe Limpiar la pantalla para seguir operando","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.btnAceptar.Click -= Informar;
            }

            private void Salir(object sender, FormClosedEventArgs e)
            {
                
                
                this.Close();    
            
            }

    }
}
