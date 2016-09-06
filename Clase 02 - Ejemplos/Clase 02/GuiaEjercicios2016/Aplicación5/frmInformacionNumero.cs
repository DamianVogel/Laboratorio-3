using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación5
{
    public partial class frmInformacionNumero : Form
    {
        public frmInformacionNumero()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

            int numero;

            

            if (int.TryParse(this.txtNumero.Text, out numero))
            {             

                this.Calcular(this.StringToIntArray(this.txtNumero.Text));

            }
            else
            {
                if (this.txtNumero.Text != "")
                {
                    this.Limpiar();

                    MessageBox.Show("Debe ingresar solo números", "Validación ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.txtNumero.Focus();

            }
           
        }


        private void Calcular(int[] cifras)
        {
            int cant = 0, impares = 0, pares = 0, suma = 0, mayor= 0, menor= 0;
            bool flag = true;

            this.RefrescarDivisores(cifras);

           
            foreach (int cifra in cifras)
            {
                cant++;
                suma += cifra;

                if (cifra % 2 == 0)
                {
                    pares += cifra;
                }
                else
                {
                    impares += cifra;
                }

                if (cifra > mayor || flag)
                {
                    mayor = cifra;
                }

                if (cifra < menor || flag)
                {
                    menor = cifra;
                    flag = false;
                }
            }




            this.txtCantidadCifras.Text = cant.ToString();
            this.txtSumaImpares.Text = impares.ToString();
            this.txtSumaPares.Text = pares.ToString();
            this.txtSumaTotal.Text = suma.ToString();
            this.txtCifraMayor.Text = mayor.ToString();
            this.txtCifraMenor.Text = menor.ToString();            

        }

        private int[] StringToIntArray(string cadena)
        {
            int[] array = new int[cadena.Length];

            for (int i = 0; i < cadena.Length; i++)
            {
                array[i] = Convert.ToInt32(cadena[i]) - 48;

            }

            return array;

        }

        private void Limpiar()
        {
            this.lsbDivisores.Items.Clear();

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control c in ((Panel)control).Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                        }
                    }
                }                    

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarDivisores(int[] cifras)
        {
            string strNum = String.Join("", cifras);
            int numero = int.Parse(strNum);

            this.lsbDivisores.Items.Clear();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    this.lsbDivisores.Items.Add(i);
                }

            }

        }

        private void frmInformacionNumero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente quiere salir?", "Confirmación Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {

                e.Cancel = true;

                this.txtNumero.Focus();

            }
        }

      
    }
}
