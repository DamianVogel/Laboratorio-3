using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Entidades;

namespace UserControls
{
    public partial class miSuperGrilla : UserControl
    {
        Object[] array;
        bool initializationOK = false;
        public Comparison<object> Comparador;
        public miSuperGrilla()
        {
            InitializeComponent();
        }

        public miSuperGrilla(Object[] array)
        {
            InitializeComponent();

            this.array = array;
            initializationOK = true;
        }

        private void miSuperGrilla_Load(object sender, EventArgs e)
        {
            if (initializationOK)
            {
                try
                {
                    Array.Sort(array, Comparador);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Comparador no asignado");
                }               
                PropertyInfo[] info = array[0].GetType().GetProperties();

                for (int i = 0; i < info.Length; i++)
                {
                    string propiedad = info.GetValue(i).ToString().Split(' ')[1].ToString();
                    dataGridView1.Columns.Add(propiedad,propiedad);

                }

                for(int j = 0; j < array.Length; j++)
                {
                    if (array[j] != null)
                    {
                        object[] fila = new object[array.Length];
                        for (int i = 0; i < info.Length; i++)
                        {
                            string nombrePropiedad = info.GetValue(i).ToString().Split(' ')[1].ToString();
                            fila.SetValue(array[j].GetType().GetProperty(nombrePropiedad).GetValue(array[j]), i);
                        }



                        dataGridView1.Rows.Add(fila);
                    }
                    
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(array[0].ToString());
        }

        public string Titulo {
            get{
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
            
       }

    }
}
