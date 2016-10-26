using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prueba_SQLAdapter
{
    public partial class Form1 : Form
    {
        private SqlConnection _miConexion;
        private SqlDataAdapter _da;
        private DataSet _ds;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._miConexion = new SqlConnection(Properties.Settings.Default.cnnDBAdapter);

            this._ds = new DataSet();

            SqlCommand comando = new SqlCommand();

            comando.CommandText = "Select * from Clientes";

            comando.Connection = this._miConexion;

            this._da = new SqlDataAdapter(comando);






        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this._da.Fill(this._ds, "Clientes");

                this.dataGridView1.DataSource = this._ds.Tables["Clientes"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        
        }
    }
}
