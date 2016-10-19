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

            this._localidad.Columns.Add("Id", typeof(String));
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
        
        }
    
    
    
    
    }


}
