using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Clase_05___Ejercicio_Entidades
{
    public partial class Form1 : Form
    {
        Class1[] lista = new Class1[10];

        public Form1()
        {
            InitializeComponent();
            Class1 numero1 = new Class1(1, "juan", 10);
            Class1 numero2 = new Class1(2, "pepe", 20);
            Class1 numero3 = new Class1(3, "pelota", 30);
            Class1 numero4 = new Class1(4, "julian", 40);
            Class1 numero5 = new Class1(5, "beto", 50);
            Class1 numero6 = new Class1(6, "carlos", 60);
            Class1 numero7 = new Class1(7, "enrique", 70);
            Class1 numero8 = new Class1(8, "caribe", 80);
            Class1 numero9 = new Class1(9, "xuabro", 90);
            Class1 numero10 = new Class1(10, "Chamho", 100);

            
            lista.SetValue(numero1, 0);
            lista.SetValue(numero2, 1);
            lista.SetValue(numero3, 2);
            lista.SetValue(numero4, 3);
            lista.SetValue(numero5, 4);
            lista.SetValue(numero6, 5);
            lista.SetValue(numero7, 6);
            lista.SetValue(numero8, 7);
            lista.SetValue(numero9, 8);
            lista.SetValue(numero10, 9);       
      
            Array.Sort(lista,Entidad.Class1.CompararPrecio);

            this.listBox1.Items.AddRange(lista);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La informacion es: " + this.listBox1.Items[0].ToString());
        }

       
        
      
        
            

    
    }
}
