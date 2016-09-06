using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_01___Windows_Form_Aplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "otro titulo";
            
            
            DialogResult respuesta = MessageBox.Show("Quiere cambiar el titulo","Pregunta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Text = this.textBox.Text;
            
            }
            //Maximiza
            //this.WindowState = FormWindowState.Maximized;
        
        }

        private void sds_TextChanged(object sender, EventArgs e)
        {

        }

        
        //Pregunta si quiere cancelar el formulario
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Quiere cancelar el cierre de la aplicacion","Pregunta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;

            }
            else
                e.Cancel = false;
        }
    }
}
