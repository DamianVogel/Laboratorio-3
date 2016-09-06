using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaicon3
{
    public partial class frmManejoCadenas : Form
    {
        public frmManejoCadenas()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char[] vector= new char[this.txtCadena.Text.Length];
            if (this.txtCadena.Text != "")
            {
                vector = this.txtCadena.Text.ToCharArray();

                Array.Reverse(vector);
                this.txtInvertida.Text = new string(vector);

                Array.Sort(vector);
                this.txtOrdenada.Text = new string(vector);
            }
            else
            {
                MessageBox.Show("Debe ingresar una cadena");
                this.txtCadena.Focus();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            this.txtCadena.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManejoCadenas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro deseas salir?", "Confirma Salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                this.txtCadena.Focus();
            }            
        }
    }
}
