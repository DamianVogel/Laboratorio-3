using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vogel.Damian._3D
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //this.listBox1.Text = this.textBox1.ToString();
           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int num = int.Parse(this.txtNumero.Text);
            string numString = this.txtNumero.Text;

            for (int i = 1; i <= 10; i++)
            {
                
      //          this.listBox1.Items.Add(num);
                this.lstTabla.Items.Add(num + " x " + i + " = "+ (num*i)); 
            
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
        }

      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiere cerrar la tabla de multiplicar?","Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true; 


        }
    }
}
