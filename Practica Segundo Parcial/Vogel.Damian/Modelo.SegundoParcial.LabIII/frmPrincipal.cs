using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vogel.Damian;
using System.Data.SqlClient;
using System.IO;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmPrincipal : Form
    {
        public DataSet _dataSetAlumnos_Cursos;
        public SqlDataAdapter _dataAdapterAlumnos;

        
        public frmPrincipal()
        {
            InitializeComponent();
            this.Text = "frmPrincipal";

            this._dataSetAlumnos_Cursos = new DataSet();
        
        }



        private void ConfigurarDataAdapter()
        {
            this._dataAdapterAlumnos = new SqlDataAdapter();
            
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand _Select = new SqlCommand("Select * from Alumnos", conexion);
            SqlCommand _Insert = new SqlCommand("INSERT Into Alumnos (Apellido,Legajo,Curso) VALUES(@Apellido, @Legajo, @Curso)", conexion);
            SqlCommand _Update = new SqlCommand("UPDATE Alumnos SET Apellido = @Apellido, Curso = @Curso Where Legajo = @Legajo ", conexion);
            SqlCommand _Delete = new SqlCommand("DELETE From Alumnos WHERE Legajo = @Legajo", conexion);

            this._dataAdapterAlumnos.SelectCommand = _Select;
            this._dataAdapterAlumnos.InsertCommand = _Insert;
            this._dataAdapterAlumnos.UpdateCommand = _Update;
            this._dataAdapterAlumnos.DeleteCommand = _Delete;
            
            
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "Curso");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "Curso");

           
            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "Legajo");

            //conexion.Close();
            


        }


        private DataTable CrearDataTableCursos()
        {
            DataTable dt_Cursos = new DataTable("Cursos");

            dt_Cursos.Columns.Add("Codigo", typeof(Int32));
            dt_Cursos.Columns.Add("Duracion", typeof(Int32));
            dt_Cursos.Columns.Add("Nombre", typeof(String));

            dt_Cursos.PrimaryKey = new DataColumn [] {dt_Cursos.Columns["Codigo"]}; 


            dt_Cursos.Columns[0].AutoIncrement = true;
            dt_Cursos.Columns[0].AutoIncrementSeed = 1000;
            dt_Cursos.Columns[0].AutoIncrementStep = 5;

            DataRow rowUno = dt_Cursos.NewRow();
            DataRow rowDos = dt_Cursos.NewRow();
            DataRow rowTres = dt_Cursos.NewRow();

            rowUno[1] = 3;
            rowUno[2] = "Java";

            rowDos[1] = 4;
            rowDos[2] = "Php";

            rowTres[1] = 5;
            rowTres[2] = "C#";

            dt_Cursos.Rows.Add(rowUno);
            dt_Cursos.Rows.Add(rowDos);
            dt_Cursos.Rows.Add(rowTres);

            dt_Cursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
            dt_Cursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");
            
            return dt_Cursos;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            
            
            this.TraerDatos();


            this.EstablecerRelacion();
        }


        private void TraerDatos()
        {
          //  SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            try
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML") && !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML"))
                {
                    DataTable nuevoDt = this.CrearDataTableCursos();
                    this._dataSetAlumnos_Cursos.Tables.Add(nuevoDt);
                }
                else
                {
                    DataTable nuevoDt = new DataTable();
                    nuevoDt.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
                    nuevoDt.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");

                    this._dataSetAlumnos_Cursos.Tables.Add(nuevoDt);

                    //this._dataSetAlumnos_Cursos.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
                    //this._dataSetAlumnos_Cursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");
                }


                this.ConfigurarDataAdapter();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);
                
                SqlCommand comando = new SqlCommand("Select * From Alumnos", conexion);
                
                conexion.Open();
                
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dtAlumno = new DataTable("dtAlumno");
                dtAlumno.Load(dataReader);

                this._dataSetAlumnos_Cursos.Tables.Add(dtAlumno);
                conexion.Close();

                //this._dataSetAlumnos_Cursos.Tables["dtAlumno"].PrimaryKey = new DataColumn[] { this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Columns["Curso"] };

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al sincronizar" + e.Message, "Error");

            }
            finally
            {
                
            }

        }


        private void EstablecerRelacion()
        {
            this._dataSetAlumnos_Cursos.Relations.Add("CursoAlumno", this._dataSetAlumnos_Cursos.Tables["Cursos"].Columns["Codigo"], this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Columns["Curso"]);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAltaAlumno = new frmAlumno();
            try
            {
                foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["Cursos"].Rows)
                {
                    frmAltaAlumno.cmbCurso.Items.Add(row["Nombre"]);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error desconocido." + a.Message, "Error");
            }

            if (frmAltaAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow nuevoAlumno = this._dataSetAlumnos_Cursos.Tables["dtAlumno"].NewRow();


                nuevoAlumno["Apellido"] = frmAltaAlumno.txtApellido.Text;
                nuevoAlumno["Legajo"] = Int16.Parse(frmAltaAlumno.txtLegajo.Text);
                nuevoAlumno["Curso"] = ((frmAltaAlumno.cmbCurso.SelectedIndex) * 5) + 1000;

                this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows.Add(nuevoAlumno);

            }
        
            
        
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaja baja = new frmBaja();
            DataRow nuevoRow = this._dataSetAlumnos_Cursos.Tables["dtAlumno"].NewRow();
            bool flag = false;


            if (baja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
                {
                    if (row["Legajo"].ToString() == baja.txtInput.Text)
                    {
                        nuevoRow = row;
                        flag = true;
                        break;
                    }
                
                }


                if (flag)
                {
                    frmAlumno frmBajaAlumno = new frmAlumno();

                    frmBajaAlumno.txtLegajo.ReadOnly = true;
                    frmBajaAlumno.txtApellido.ReadOnly = true;
                    frmBajaAlumno.cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;

                    frmBajaAlumno.txtApellido.Text = nuevoRow["Apellido"].ToString();
                    frmBajaAlumno.txtLegajo.Text = nuevoRow["Legajo"].ToString();


                    DataRow rowPadre = nuevoRow.GetParentRow("CursoAlumno");
                    frmBajaAlumno.cmbCurso.Items.Add(rowPadre["Nombre"].ToString());
                    frmBajaAlumno.cmbCurso.SelectedIndex = 0;


                    if (frmBajaAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
                        {
                            if (row["Legajo"].ToString() == baja.txtInput.Text)
                            {
                                row.Delete();
                                break;
                            }

                        }


                    }
                }
                else
                    MessageBox.Show("No se encontro el legajo", "Error");
               
            
            }

        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frmBaja baja = new frmBaja();
            DataRow nuevoRow = this._dataSetAlumnos_Cursos.Tables["dtAlumno"].NewRow();
            bool flag = false;
            int indexMod = 0;

            if (baja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows.Count; i++)
                {
                    if (this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[i]["Legajo"].ToString() == baja.txtInput.Text)
                    {
                        nuevoRow = this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[i];
                        flag = true;
                        indexMod = i;
                        
                        break;
                    }
                
                
                }
               


                if (flag)
                {
                    
                    
                    
                    frmAlumno frmModificarAlumno = new frmAlumno();

                    foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["Cursos"].Rows)
                    {
                        frmModificarAlumno.cmbCurso.Items.Add(row["Nombre"]);
                    }


                    frmModificarAlumno.txtLegajo.ReadOnly = true;
                   // frmBajaAlumno.txtApellido.ReadOnly = true;
                    //frmBajaAlumno.cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;

                    frmModificarAlumno.txtApellido.Text = nuevoRow["Apellido"].ToString();
                    frmModificarAlumno.txtLegajo.Text = nuevoRow["Legajo"].ToString();

                     DataRow rowPadre = nuevoRow.GetParentRow("CursoAlumno");

                     for (int i = 0; i < frmModificarAlumno.cmbCurso.Items.Count;i++ )
                     {
                         if (frmModificarAlumno.cmbCurso.Items[i].ToString() == rowPadre["Nombre"])
                         {
                             frmModificarAlumno.cmbCurso.SelectedIndex = i;
                         }
                     
                     }


                    //DataRow rowPadre = nuevoRow.GetParentRow("CursoAlumno");
                    //frmModificarAlumno.cmbCurso.Items.Add(rowPadre["Nombre"].ToString());
                    //frmModificarAlumno.cmbCurso.SelectedIndex = 0;


                    if (frmModificarAlumno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[indexMod]["Apellido"] = frmModificarAlumno.txtApellido.Text;
                        this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows[indexMod]["Curso"] = ((frmModificarAlumno.cmbCurso.SelectedIndex) * 5) + 1000;

                    }
                }
                else
                    MessageBox.Show("No se encontro el legajo", "Error");
               
            
            }

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();
            
            
            foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            { 
                //DataRow rowPadre = row.GetParentRow("CursoAlumno");

                frmMostrar.listBox1.Items.Add(row["Apellido"].ToString() + " " + row["Legajo"].ToString()); 
            
            }

            frmMostrar.Show(this);


        }

        private void alumnosCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();


            foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            {
                DataRow rowPadre = row.GetParentRow("CursoAlumno");

                frmMostrar.listBox1.Items.Add(row["Apellido"].ToString() + " " + row["Legajo"].ToString() + " " + rowPadre["Nombre"].ToString());

            }

            frmMostrar.Show(this);
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();


            foreach (DataRow row in this._dataSetAlumnos_Cursos.Tables["Cursos"].Rows)
            {
                //DataRow rowPadre = row.GetParentRow("CursoAlumno");

                frmMostrar.listBox1.Items.Add(row["Codigo"].ToString() + " " + row["Duracion"].ToString() + " " + row["Nombre"].ToString());

            }

            frmMostrar.Show(this);
        }

        private void mostrarAlumnosASPNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow[] row1005 = this._dataSetAlumnos_Cursos.Tables["Cursos"].Select("Codigo = '1005'");

            DataRow[] alumnos1005 = row1005[0].GetChildRows("CursoAlumno");

            FrmMostrar frmMostrar = new FrmMostrar();

            foreach (DataRow row in alumnos1005)
            {
                frmMostrar.listBox1.Items.Add(row["Apellido"].ToString() + " " + row["Legajo"].ToString());
            }

            frmMostrar.Show(this);

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);
            try
            {
                this._dataAdapterAlumnos.Update(this._dataSetAlumnos_Cursos.Tables["dtAlumno"]);

            }
            catch (Exception b)
            {
                MessageBox.Show("No sincronizo un choto  porque: " + b.Message, "Error");
               
            }
            

        }

        




    }
}
