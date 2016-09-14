using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
            {

                if (txtMonto.Text != "")
                {


                    float montoFloat = float.Parse(txtMonto.Text);
                    float descuentoFloat;
                    float totalFloat;

                    if (montoFloat >= 30f && montoFloat <= 50f)
                    {
                        descuentoFloat = (montoFloat * 10) / 100;
                        txtDescuento.Text = descuentoFloat.ToString();

                        totalFloat = montoFloat - descuentoFloat;
                        txtTotal.Text = totalFloat.ToString();
                    }
                    else if (montoFloat > 50f)
                    {
                        descuentoFloat = (montoFloat * 20) / 100;
                        txtDescuento.Text = descuentoFloat.ToString();

                        totalFloat = montoFloat - descuentoFloat;
                        txtTotal.Text = totalFloat.ToString();

                    }

                    else
                    {
                        txtDescuento.Text = (0).ToString();
                        txtTotal.Text = montoFloat.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Indique el monto a cobrar","Error");
                        
                }
                
       
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Close();

            this.Close();
        }

       
        
    }
}
