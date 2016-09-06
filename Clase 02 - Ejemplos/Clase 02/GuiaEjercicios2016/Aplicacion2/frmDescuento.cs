using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion2
{
    public partial class frmDescuento : Form
    {
        public frmDescuento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float monto;
            float descuento;
            if (float.TryParse(this.txtMonto.Text, out monto))
            {
                if (monto < 30)
                {
                    descuento = 0;
                }
                else if (monto < 50)
                {
                    descuento = monto * .1f;
                }
                else
                {
                    descuento = monto * .2f;
                }

                this.txtDescuento.Text = descuento.ToString();
                this.txtTotal.Text = (monto - descuento).ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar un monto válido");
                this.txtMonto.Clear();
                this.txtMonto.Focus();
            }
               
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.grbInformacion.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                } 
            }

            this.txtMonto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDescuento_Load(object sender, EventArgs e)
        {

        }

        private void frmDescuento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro deseas salir?", "Confirma Salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                this.txtMonto.Focus();               
            }            
        }
      
    }
}
