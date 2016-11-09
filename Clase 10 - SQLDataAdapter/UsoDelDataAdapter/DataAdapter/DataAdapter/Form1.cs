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

namespace DataAdapter
{
    public partial class Form1 : Form
    {
        private DataSet _dataSet;
        private SqlDataAdapter _dataAdapter;
        private SqlCommand _Select;
        private SqlCommand _Insert;
        private SqlCommand _Update;
        private SqlCommand _Delete;
        private SqlConnection _Connection;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Primero realizamos la conexion
            this._Connection = new SqlConnection(Properties.Settings.Default.cnn_UTN_Negocio);

            //Realizamos los commands
            this._Select = new SqlCommand("SELECT * FROM Productos", this._Connection);

            this._Insert = new SqlCommand("INSERT INTO Productos (Nombre, Tipo, Proveedor) VALUES (@Nombre, @Tipo, @Proveedor)", this._Connection);

            this._Update = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Tipo = @Tipo, Proveedor = @Proveedor WHERE Id_Producto = @Id_Producto", this._Connection);

            this._Delete = new SqlCommand("DELETE FROM Productos WHERE Id_Producto = @Id_Producto", this._Connection);


            this._dataAdapter = new SqlDataAdapter();

            this._dataAdapter.SelectCommand = this._Select;
            this._dataAdapter.InsertCommand = this._Insert;
            this._dataAdapter.UpdateCommand = this._Update;
            this._dataAdapter.DeleteCommand = this._Delete;

            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

            this._dataAdapter.UpdateCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 50, "Tipo");
            this._dataAdapter.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50, "Proveedor");

            this._dataAdapter.DeleteCommand.Parameters.Add("@Id_Producto", SqlDbType.Int, 18, "Id_Producto");

            this.TraerDatos();

            this.MostrarDatos();


            this.FormClosing += this.Salir;
        }

        private void TraerDatos()
        {
            try
            {
                this._dataSet = new DataSet();

                this._dataAdapter.Fill(this._dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", ex.Message);
            }

        }

        private void MostrarDatos()
        {
            this.lstDatos.Items.Clear();

            foreach (DataRow fila in this._dataSet.Tables[0].Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    this.lstDatos.Items.Add("Nombre: " + fila[1].ToString() + " Tipo: " +
                    fila[2].ToString() + " Proveedor: " + fila[3].ToString());
                }
            }
        }

        private void EliminarDatos()
        {
            try
            {
                this._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex].Delete();
                this.MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormDatos frmModificar = new FormDatos();

            frmModificar.Text = "Modificar Datos";

            frmModificar.Nombre = this._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Nombre"].ToString();
            frmModificar.Tipo = this._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Tipo"].ToString();
            frmModificar.Proveedor = this._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex]["Proveedor"].ToString();

            //frmModificar.Show(this);

            if (frmModificar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int indice = this.lstDatos.SelectedIndex;
                this._dataSet.Tables[0].Rows[indice]["Nombre"] = frmModificar.Nombre;
                this._dataSet.Tables[0].Rows[indice]["Tipo"] = frmModificar.Tipo;
                this._dataSet.Tables[0].Rows[indice]["Proveedor"] = frmModificar.Proveedor;

                this.MostrarDatos();


            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatos frmAgregar = new FormDatos();

            frmAgregar.Text = "Agregar";


            if (frmAgregar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow row = this._dataSet.Tables[0].NewRow();

                row["Nombre"] = frmAgregar.Nombre;
                row["Tipo"] = frmAgregar.Tipo;
                row["Proveedor"] = frmAgregar.Proveedor;

                this._dataSet.Tables[0].Rows.Add(row);

                this.MostrarDatos();


            }





        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapter.Update(this._dataSet);

                MessageBox.Show("Lo sincronizo jamon");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No sincronizo un choto", ex.Message);
                
            }
        }

        private void Salir(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Realmente desea salir????", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            this.MostrarEstadoFilas(this._dataSet);

        }

        private void MostrarEstadoFilas(DataSet dataset)
        {
            FrmEstado frmEstado = new FrmEstado();

            frmEstado.Text = "Estado de las filas";

            int contador = 0;

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                frmEstado.lstMostrar.Items.Add("Fila: " + contador + "Estado: " + row.RowState.ToString());
                contador = contador + 1;
                
            
            }

            frmEstado.ShowDialog();
            
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this._dataSet.Tables[0].Rows[this.lstDatos.SelectedIndex].Delete();


            this.MostrarDatos();
            //this.btnContar_Click(sender, e);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            SqlCommand comando = new SqlCommand("Select * from Productos", this._Connection);
            try
            {
                this._Connection.Open();
                SqlDataReader lector = comando.ExecuteReader();
                DataTable nuevaTabla = new DataTable("nueva");
                
                nuevaTabla.Load(lector);

                MessageBox.Show(nuevaTabla.Rows[0][0].ToString());
                                    
                while (lector.Read())
                {                                   
                    contador = contador + 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this._Connection.Close();
            }
        }
    
    
    
    }
}