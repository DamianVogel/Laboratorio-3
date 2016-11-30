using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.SqlClient;
using System.IO;

namespace Practica_Recuperatorio_Segundo_Parcuial
{
    public partial class FrmPrincipal : Form
    {
        DataSet _dataSetAlumnos_Cursos;
        SqlDataAdapter _dataAdapterAlumnos;
        
        
        public FrmPrincipal()
        {
            InitializeComponent();

            this._dataSetAlumnos_Cursos= new DataSet("AlumnosCursos");
            this._dataAdapterAlumnos = new SqlDataAdapter();
        }


        #region Metodos

        private DataTable CrearDataTableCursos()
        {
            DataTable dtCursos = new DataTable("dtCursos");

            dtCursos.Columns.Add("Codigo", typeof(int));
            dtCursos.Columns.Add("Duracion", typeof(int));
            dtCursos.Columns.Add("Nombre", typeof(string));

            dtCursos.Columns[0].AutoIncrement = true;
            dtCursos.Columns[0].AutoIncrementSeed = 1000;
            dtCursos.Columns[0].AutoIncrementStep = 5;

            DataRow cursoUno = dtCursos.NewRow();
            DataRow cursoDos = dtCursos.NewRow();
            DataRow cursoTres = dtCursos.NewRow();

            cursoUno[1] = 2;
            cursoUno[2] = "Java";

            cursoDos[1] = 3;
            cursoDos[2] = "PHP";

            cursoTres[1] = 5;
            cursoTres[2] = ".NET";

            dtCursos.Rows.Add(cursoUno);
            dtCursos.Rows.Add(cursoDos);
            dtCursos.Rows.Add(cursoTres);



            return dtCursos;
        
        }

        private void ConfigurarDataAdapter()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand select = new SqlCommand("Select _Apellido as Apellido, _Legajo as Legajo, _Curso as Curso from Alumnos", conexion);
            SqlCommand insert = new SqlCommand("Insert into Alumnos (_Apellido,_Legajo,_Curso) VALUES (@Apellido,@Legajo,@Curso)", conexion);
            SqlCommand update = new SqlCommand("Update Alumnos Set _Apellido=@Apellido, _Legajo=@Legajo, _Curso=@Curso", conexion);
            SqlCommand delete = new SqlCommand("Delete from Alumnos where _Legajo = @Legajo", conexion);

            this._dataAdapterAlumnos.SelectCommand = select;
            this._dataAdapterAlumnos.InsertCommand = insert;
            this._dataAdapterAlumnos.UpdateCommand = update;
            this._dataAdapterAlumnos.DeleteCommand = delete;

            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Legajo", SqlDbType.Int, 50, "Legajo");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Curso", SqlDbType.Int, 50, "Curso");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Legajo", SqlDbType.Int, 50, "Legajo");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Curso", SqlDbType.Int, 50, "Curso");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@Legajo", SqlDbType.Int, 50, "Legajo");
      
        
        }

        private void TraerDatos()
        {

            #region Llenar el table de Cursos

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML") && !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML"))
            {
                this._dataSetAlumnos_Cursos.Tables.Add(this.CrearDataTableCursos());

                this._dataSetAlumnos_Cursos.Tables[0].WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");
                this._dataSetAlumnos_Cursos.Tables[0].WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
            }
            else
            {
                DataTable dtCursos = new DataTable("dtCursos");

                dtCursos.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
                dtCursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");

                this._dataSetAlumnos_Cursos.Tables.Add(dtCursos);

            }

            #endregion



            #region Llenar el table de alumnos desde la base de datos
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand select = new SqlCommand("Select _Apellido as Apellido, _Legajo as Legajo, _Curso as Curso from Alumnos", conexion);

            conexion.Open();

            SqlDataReader reader = select.ExecuteReader();

            
            DataTable dtAlumnos = new DataTable();

            dtAlumnos.Load(reader);
            
            conexion.Close();
            
            this._dataSetAlumnos_Cursos.Tables.Add(dtAlumnos);
            #endregion


            this.dataGridView1.DataSource = this._dataSetAlumnos_Cursos.Tables[1];

        }




        #endregion



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarDataAdapter();

            TraerDatos();




        }
    
    
    
    }
}
