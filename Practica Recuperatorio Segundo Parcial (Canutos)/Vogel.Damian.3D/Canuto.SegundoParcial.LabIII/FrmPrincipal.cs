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
using Entidades;
using System.IO;
using Microsoft.VisualBasic;



namespace Canuto.SegundoParcial.LabIII
{
    public partial class FrmPrincipal : Form
    {
        DataSet _dataSetCanutos_Escondites;
        SqlDataAdapter _dataAdapterCanutos;

        public FrmPrincipal()
        {
            InitializeComponent();

            this._dataAdapterCanutos = new SqlDataAdapter();
            this._dataSetCanutos_Escondites = new DataSet("Canutos");

        }


        private DataTable CrearDataTableEscondite()
        {
            DataTable dtEscondites = new DataTable("dtEscondites");

            dtEscondites.Columns.Add("CodEscondite", typeof(int));
            dtEscondites.Columns.Add("Lugar", typeof(string));

            dtEscondites.Columns[0].AutoIncrement = true;
            dtEscondites.Columns[0].AutoIncrementSeed = 1000;
            dtEscondites.Columns[0].AutoIncrementStep = 5;

            DataRow primerEscondite = dtEscondites.NewRow();
            DataRow segundoEscondite = dtEscondites.NewRow();
            DataRow tercerEscondite = dtEscondites.NewRow();
            DataRow cuartoEscondite = dtEscondites.NewRow();

            primerEscondite[1] = "Convento";
            segundoEscondite[1] = "Dragon";
            tercerEscondite[1] = "Skanka";
            cuartoEscondite[1] = "Bodega de Lopez";

            dtEscondites.Rows.Add(primerEscondite);
            dtEscondites.Rows.Add(segundoEscondite);
            dtEscondites.Rows.Add(tercerEscondite);
            dtEscondites.Rows.Add(cuartoEscondite);

            dtEscondites.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesEsquema.XML");
            dtEscondites.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesDatos.XML");


            return dtEscondites;


        }

        private void ConfigurarDataAdapter()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand select = new SqlCommand("Select BaseId as Id, BaseNombre as Nombre, BaseApellido as Apellido, BaseDolares as Dolares, BaseEscondite as codigoEscondite from Canutos", conexion);
            SqlCommand insert = new SqlCommand("Insert into Canutos (BaseId,BaseNombre,BaseApellido,BaseDolares,BaseEscondite) values (@Id,@Nombre,@Apellido,@Dolares,@codigoEscondite)", conexion);
            SqlCommand update = new SqlCommand("Update Canutos set BaseId = @Id, BaseNombre = @Nombre, BaseApellido = @Apellido, BaseDolares = @Dolares, BaseEscondite = @codigoEscondite", conexion);
            SqlCommand delete = new SqlCommand("Delete from Canutos where BaseId = @Id", conexion);

            this._dataAdapterCanutos.SelectCommand = select;
            this._dataAdapterCanutos.InsertCommand = insert;
            this._dataAdapterCanutos.UpdateCommand = update;
            this._dataAdapterCanutos.DeleteCommand = delete;

            this._dataAdapterCanutos.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");
            this._dataAdapterCanutos.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapterCanutos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterCanutos.InsertCommand.Parameters.Add("@Dolares", SqlDbType.Float, 50, "Dolares");
            this._dataAdapterCanutos.InsertCommand.Parameters.Add("@codigoEscondite", SqlDbType.Int, 50, "codigoEscondite");


            this._dataAdapterCanutos.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");
            this._dataAdapterCanutos.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapterCanutos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterCanutos.UpdateCommand.Parameters.Add("@Dolares", SqlDbType.Float, 50, "Dolares");
            this._dataAdapterCanutos.UpdateCommand.Parameters.Add("@codigoEscondite", SqlDbType.Int, 50, "codigoEscondite");

            this._dataAdapterCanutos.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 50, "Id");



        }

        private void TraerDatos()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            DataTable dtCanutos = new DataTable("dtCanutos");

            conexion.Open();
            SqlCommand select = new SqlCommand("Select BaseId as Id, BaseNombre as Nombre, BaseApellido as Apellido, BaseDolares as Dolares, BaseEscondite as codigoEscondite from Canutos", conexion);

            SqlDataReader reader = select.ExecuteReader();

            dtCanutos.Load(reader);

            this._dataSetCanutos_Escondites.Tables.Add(dtCanutos);

            this.dataGridView1.DataSource = this._dataSetCanutos_Escondites.Tables[0];

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesEsquema.XML") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesDatos.XML"))
            {
                DataTable dtEscondites = new DataTable("dtEscondites");

                dtEscondites.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesEsquema.XML");
                dtEscondites.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\EsconditesDatos.XML");

                this._dataSetCanutos_Escondites.Tables.Add(dtEscondites);

            }
            else
            {

                DataTable dtEscondites = this.CrearDataTableEscondite();

                this._dataSetCanutos_Escondites.Tables.Add(dtEscondites);


            }





        }

        private void EstablecerRelacion()
        {
            DataRelation canutoEscondite = new DataRelation("canutoEscondite", this._dataSetCanutos_Escondites.Tables[1].Columns[0],
                                                                              this._dataSetCanutos_Escondites.Tables[0].Columns[4]);

            this._dataSetCanutos_Escondites.Relations.Add(canutoEscondite);

        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.ConfigurarDataAdapter();

            this.TraerDatos();

            this.EstablecerRelacion();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAvion frmAltaCanuto = new FrmAvion();

            foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[1].Rows)
            {
                frmAltaCanuto.cbmEscondite.Items.Add(row["Lugar"].ToString());

            }

            if (frmAltaCanuto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {



                DataRow nuevoCanuto = this._dataSetCanutos_Escondites.Tables[0].NewRow();

                nuevoCanuto["Id"] = frmAltaCanuto.Canuto.Id;
                nuevoCanuto["Apellido"] = frmAltaCanuto.Canuto.Apellido;
                nuevoCanuto["Nombre"] = frmAltaCanuto.Canuto.Nombre;
                nuevoCanuto["Dolares"] = frmAltaCanuto.Canuto.Dolares;
                nuevoCanuto["codigoEscondite"] = ((frmAltaCanuto.Canuto.CodEscondite) * 5) + 1000;

                this._dataSetCanutos_Escondites.Tables[0].Rows.Add(nuevoCanuto);

            }
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string legajo = Interaction.InputBox("Legajo a buscar", "Legajo");
            int flag = 0;


            foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[0].Rows)
            {
                if (row["Id"].ToString() == legajo)
                {
                    flag = 1;

                    FrmAvion frmBajaCanuto = new FrmAvion(new Entidades.Canuto(int.Parse(row["Id"].ToString()), row["Nombre"].ToString(), row["Apellido"].ToString(), float.Parse(row["Dolares"].ToString()), int.Parse(row["codigoEscondite"].ToString())));



                    if (frmBajaCanuto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        row.Delete();
                        break;
                    }


                }



            }

            if (flag == 0)
            {
                MessageBox.Show("NO SE ENCONTRO EL LEGAJO");

            }


        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string legajo = Interaction.InputBox("Legajo a buscar", "Legajo");
            int flag = 0;

            int index = 0;

            for (int i = 0; i < this._dataSetCanutos_Escondites.Tables[0].Rows.Count; i++)
            {
                if (this._dataSetCanutos_Escondites.Tables[0].Rows[i]["Id"].ToString() == legajo)
                {
                    flag = 1;
                    index =i;
                    
                   
                    
                    
                    FrmAvion frmModCanuto = new FrmAvion(new Entidades.Canuto(int.Parse(this._dataSetCanutos_Escondites.Tables[0].Rows[i]["Id"].ToString()), this._dataSetCanutos_Escondites.Tables[0].Rows[i]["Nombre"].ToString(), this._dataSetCanutos_Escondites.Tables[0].Rows[i]["Apellido"].ToString(), float.Parse(this._dataSetCanutos_Escondites.Tables[0].Rows[i]["Dolares"].ToString()), int.Parse(this._dataSetCanutos_Escondites.Tables[0].Rows[i]["codigoEscondite"].ToString())));

                    foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[1].Rows)
                    {
                        frmModCanuto.cbmEscondite.Items.Add(row["Lugar"].ToString());

                    }


                    if (frmModCanuto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        this._dataSetCanutos_Escondites.Tables[0].Rows.RemoveAt(index);
                        DataRow nuevoCanuto = this._dataSetCanutos_Escondites.Tables[0].NewRow();

                        nuevoCanuto["Id"] = frmModCanuto.Canuto.Id;
                        nuevoCanuto["Apellido"] = frmModCanuto.Canuto.Apellido;
                        nuevoCanuto["Nombre"] = frmModCanuto.Canuto.Nombre;
                        nuevoCanuto["Dolares"] = frmModCanuto.Canuto.Dolares;
                        nuevoCanuto["codigoEscondite"] = ((frmModCanuto.Canuto.CodEscondite) * 5) + 1000;
                        
                        this._dataSetCanutos_Escondites.Tables[0].Rows.InsertAt(nuevoCanuto,index);
                        
                        
                        

                    }



                }

            }
            if (flag == 0)
            {
                MessageBox.Show("NO SE ENCONTRO EL LEGAJO");

            }





        }

        private void canutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar muestraCanutos = new FrmMostrar();

             muestraCanutos.listBox1.Items.Add("Los canutos son: ");

            foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[0].Rows)
            {
                muestraCanutos.listBox1.Items.Add(row["Nombre"].ToString() + " " + row["Apellido"].ToString());         
            }

            muestraCanutos.ShowDialog();


        }

        private void esconditesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar muestraEscondites = new FrmMostrar();

            muestraEscondites.listBox1.Items.Add("Los escondites son: ");

            foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[1].Rows)
            {
                muestraEscondites.listBox1.Items.Add(row["Lugar"].ToString());
            }

            muestraEscondites.ShowDialog();


        }

        private void canutosConEsconditesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar muestraCanEsc = new FrmMostrar();

            muestraCanEsc.listBox1.Items.Add("Los canutos con sus escondites son: ");

            foreach (DataRow row in this._dataSetCanutos_Escondites.Tables[0].Rows)
            {
                DataRow rowPadre = row.GetParentRow("canutoEscondite");
                

                
                muestraCanEsc.listBox1.Items.Add(row["Nombre"].ToString() + " " + row["Apellido"].ToString()+" y tiene la guitarra en:"+ rowPadre["Lugar"].ToString());
            }

            muestraCanEsc.ShowDialog();



        }

        private void canutosEnConventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMostrar muestraCanConvento = new FrmMostrar();

            muestraCanConvento.listBox1.Items.Add("Los canutos que esconden todo en el convento son: ");

            DataRow[] rowConvento = this._dataSetCanutos_Escondites.Tables[1].Select("Lugar = 'Convento'");

            DataRow[] rowCanutosConvento = rowConvento[0].GetChildRows("canutoEscondite");

            foreach (DataRow row in rowCanutosConvento)
            {
                
                muestraCanConvento.listBox1.Items.Add(row["Nombre"].ToString() + " " + row["Apellido"].ToString());
            }

            muestraCanConvento.ShowDialog();




        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                this._dataAdapterCanutos.Update(this._dataSetCanutos_Escondites.Tables[0]);

                MessageBox.Show("Lo actualizo de 10");
            
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message, "ANDA COMO EL ORTO");
            }
            




        }

        private void Salir(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Salir?", "Salir???", MessageBoxButtons.OKCancel);


            DialogResult respuesta = MessageBox.Show("Salir?", "Salir???", MessageBoxButtons.OKCancel);

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = false;
            
            
            }
            else
                e.Cancel = true;
        
        
        }
    
    
    
    
    
    
    
    
    
    }
   }
