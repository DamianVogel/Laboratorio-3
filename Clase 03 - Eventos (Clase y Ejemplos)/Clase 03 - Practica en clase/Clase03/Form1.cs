using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click -= this.button1_Click;
            this.button2.Click -= this.button2_Click;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Click += this.button1_Click;
            this.button2.Click += this.button2_Click;
            this.button3.Click += this.ManejadorCentral;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "button1")
            {
                MessageBox.Show("Apretas el boton 1");
            }
            if(button.Name == "button2")
            {
                MessageBox.Show("Apretaste el boton 2");
            }
            if (button.Name == "button3")
            {
                MessageBox.Show("Apretaste el boton 3");
            }
            else
                MessageBox.Show("Anda como el orto");
            
        }
    
    
    }
}
