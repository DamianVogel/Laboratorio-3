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

            this.cmbCurso.SelectedIndexChanged += this.LlenarListBox;

            this.Load += this.LlenarListBox;

        }

        private void LlenarListBox(object sender, EventArgs e)
        {

            FrmPrincipal dueño = (FrmPrincipal)this.Owner;

            DataSet envio = dueño.miDelegado(dueño.dsInscripcion);

            foreach (DataRow row in envio.Tables["Cursos"].Rows)
            {
                this.lstMostrar.Items.Add(row["Descripcion"].ToString());
            
            }







        
        }
    
    
    
    }
}
