using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion4
{
    public partial class frmOrdenamiento : Form
    {

        private List<int> lista;

        public frmOrdenamiento()
        {
            InitializeComponent();

            lista = new List<int>();
        }

        private void frmOrdenamiento_Load(object sender, EventArgs e)
        {
            this.btnSalir.Image = Properties.Resources.iconoSalir;
            this.rdbAscendente.Select();
            this.txtNumero.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;            

            if(int.TryParse(this.txtNumero.Text,out numero))
            {
                this.lista.Add(numero);
                this.ActualizarLista();

            }
            else
            {
                MessageBox.Show("Debe ingresar un número", "Entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.txtNumero.Clear();
            this.txtNumero.Focus();
        }

        private void OrdenarLista(bool criterio)
        {
            int aux;
           
                for (int i = 0; i < this.lista.Count - 1; i++)
                {
                    for (int j = i + 1; j < this.lista.Count; j++)
                    {
                        if (criterio)
                        {
                            if (lista[i] < lista[j])
                            {
                                aux = this.lista[i];
                                this.lista[i] = this.lista[j];
                                this.lista[j] = aux;
                            }
                        }
                        else
                        {
                            if (lista[i] > lista[j])
                            {
                                aux = this.lista[i];
                                this.lista[i] = this.lista[j];
                                this.lista[j] = aux;
                            }

                        }

                    }
                }

                this.ActualizarLista();
            
        }

        private void ActualizarLista()
        {
            this.lsbNumeros.Items.Clear();

            foreach (int numero in this.lista)
            {
                this.lsbNumeros.Items.Add(numero);

            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
                       
                this.OrdenarLista(rdbAscendente.Checked);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrdenamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente quiere salir?", "Confirmación Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {

                e.Cancel = true;

                this.txtNumero.Focus();

            }

        }
    }
}
