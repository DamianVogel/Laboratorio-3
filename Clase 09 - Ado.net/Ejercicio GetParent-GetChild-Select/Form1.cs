using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_GetParent_GetChild_Select
{
    public partial class FrmPrincipal : Form
    {

        private DataTable _productos;
        private DataTable _proveedor;
        private DataTable _localidad;

        private DataSet _negocio;


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrearSetTable_Click(object sender, EventArgs e)
        {
            this._negocio = new DataSet("DataSet");
            
            this._productos=new DataTable("Productos");
            this._proveedor=new DataTable("Proveedor");
            this._localidad = new DataTable("Localidad");

            this._productos.Columns.Add("Id", typeof(Int32));
            this._productos.Columns.Add("Descripcion", typeof(String));
            this._productos.Columns.Add("IdProveedor", typeof(Int32));
            this._productos.PrimaryKey = new DataColumn[] {this._productos.Columns["Id"]};


            this._proveedor.Columns.Add("Id", typeof(Int32));
            this._proveedor.Columns.Add("Nombre", typeof(String));
            this._proveedor.Columns.Add("IdLocalidad", typeof(Int32));
            this._proveedor.PrimaryKey = new DataColumn[] { this._proveedor.Columns["Id"] };

            this._localidad.Columns.Add("Id", typeof(Int32));
            this._localidad.Columns.Add("Localidad", typeof(String));
            this._localidad.PrimaryKey = new DataColumn[] { this._localidad.Columns["Id"] };


            this._negocio.Tables.Add(this._productos);
            this._negocio.Tables.Add(this._proveedor);
            this._negocio.Tables.Add(this._localidad);

            MessageBox.Show("DataTables y DataSet creados");


        }

        private void btnCrearRelaciones_Click(object sender, EventArgs e)
        {
            DataRelation relacionProdProv = new DataRelation("ProductosProveedor", this._negocio.Tables["Proveedor"].Columns["Id"],this._negocio.Tables["Productos"].Columns["IdProveedor"]);
            DataRelation relacionProvLoc = new DataRelation("ProveedorLocalidad", this._negocio.Tables["Localidad"].Columns["Id"], this._negocio.Tables["Proveedor"].Columns["IdLocalidad"]);

            this._negocio.Relations.Add(relacionProdProv);
            this._negocio.Relations.Add(relacionProvLoc);
        
    
        // foreach(DataRow Fila in this._negocio.Tables["Prod
        
        
        
        }

        private void btnCargarLocalidades_Click(object sender, EventArgs e)
        {
            DataRow fila1 = this._localidad.NewRow();

            fila1["Id"] = 1;
            fila1["Localidad"] = "Burzaco";

            this._localidad.Rows.Add(fila1);

            DataRow fila2 = this._localidad.NewRow();

            fila2["Id"] = 2;
            fila2["Localidad"] = "Adrogue";

            this._localidad.Rows.Add(fila2);

            DataRow fila3 = this._localidad.NewRow();

            fila3["Id"] = 3;
            fila3["Localidad"] = "Banfield";

            this._localidad.Rows.Add(fila3);

            MessageBox.Show("Localidades Creadas y cargadas al table de localidades");

        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {

            DataRow fila1 = this._proveedor.NewRow();

            fila1["Id"] = 1;
            fila1["Nombre"] = "Pepito";
            fila1["IdLocalidad"] = 1;

            this._proveedor.Rows.Add(fila1);

            DataRow fila2 = this._proveedor.NewRow();

            fila2["Id"] = 2;
            fila2["Nombre"] = "Juancito";
            fila2["IdLocalidad"] = 2;

            this._proveedor.Rows.Add(fila2);

            DataRow fila3 = this._proveedor.NewRow();

            fila3["Id"] = 3;
            fila3["Nombre"] = "Margarita";
            fila3["IdLocalidad"] = 3;

            this._proveedor.Rows.Add(fila3);

            MessageBox.Show("Proveedores Creados y cargados al table de proveedores");


        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {

            DataRow fila1 = this._productos.NewRow();

            fila1["Id"] = 1;
            fila1["Descripcion"] = "Alfajor";
            fila1["IdProveedor"] = 2;

            this._productos.Rows.Add(fila1);

            DataRow fila2 = this._productos.NewRow();

            fila2["Id"] = 2;
            fila2["Descripcion"] = "Tortilla";
            fila2["IdProveedor"] = 2;

            this._productos.Rows.Add(fila2);

            DataRow fila3 = this._productos.NewRow();

            fila3["Id"] = 3;
            fila3["Descripcion"] = "Jugo";
            fila3["IdProveedor"] = 3;

            this._productos.Rows.Add(fila3);

            MessageBox.Show("Productos Creados y cargados al table de productos");


        }

        private void btnMosProdProveedor_Click(object sender, EventArgs e)
        {

            this.lstMostrar.Items.Clear();

            foreach (DataRow fila in this._productos.Rows)
            {
                

                DataRow filaPadre = fila.GetParentRow("ProductosProveedor");
                
                
                this.lstMostrar.Items.Add(fila["Id"].ToString() +" - "+ fila["Descripcion"].ToString() +" - "+ filaPadre["Nombre"].ToString());


            }



        }

        private void btnMosProvLocalidad_Click(object sender, EventArgs e)
        {

            this.lstMostrar.Items.Clear();
            
            foreach (DataRow fila in this._proveedor.Rows)
            {


                DataRow filaPadre = fila.GetParentRow("ProveedorLocalidad");


                this.lstMostrar.Items.Add(fila["Id"].ToString() + " - " + fila["Nombre"].ToString() + " - " + filaPadre["Localidad"].ToString());


            }

        }

        private void btnMosProdProvLocalidad_Click(object sender, EventArgs e)
        {
            this.lstMostrar.Items.Clear();

            foreach (DataRow fila in this._productos.Rows)
            {


                DataRow filaPadre = fila.GetParentRow("ProductosProveedor");

                DataRow filaPadre2 = filaPadre.GetParentRow("ProveedorLocalidad");


                this.lstMostrar.Items.Add(fila["Id"].ToString() + " - " + fila["Descripcion"].ToString() + " - " + filaPadre["Nombre"].ToString() + " - " + filaPadre2["Localidad"].ToString() );


            }
        }
    
    
    
    
    }


}
