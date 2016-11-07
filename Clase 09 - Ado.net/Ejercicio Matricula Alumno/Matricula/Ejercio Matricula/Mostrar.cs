using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio_Matricula
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();


        }

        private void LlenarListBox(DataSet dataSet)
        {
           
            
           
            foreach(DataRow row in dataSet.Tables["Curso"].Rows)
            {
                this.lstMostrar.Items.Add(row["Descripcion"].ToString());
            
            }
           
        
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado = LlenarListBox;


        }
    
    
    
    }
}
