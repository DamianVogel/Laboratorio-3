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


namespace Apruebo
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        SqlDataAdapter dataAdapter;
        SqlConnection sqlConnection;
        
        
        
        public Form1()
        {
            InitializeComponent();

            this.dataSet = new DataSet();
            this.sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
        }

        public void ConfDataAdapter()
        {
            this.dataAdapter = new SqlDataAdapter();

            this.dataAdapter.SelectCommand = new SqlCommand("Select * From Envios",this.sqlConnection);


            this.dataAdapter.Fill(this.dataSet.Tables.Add());

            this.dataGridView1.DataSource = this.dataSet.Tables[0];

        
        
        }


        public void ConstructorDeTablas()
        { 
            
            
        
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConfDataAdapter();
        }
    
    
    
    }
}
