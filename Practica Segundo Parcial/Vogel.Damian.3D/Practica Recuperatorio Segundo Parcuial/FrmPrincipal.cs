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
        
        }

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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML") && !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML"))
            {
                this._dataSetAlumnos_Cursos.Tables.Add(this.CrearDataTableCursos());

                this._dataSetAlumnos_Cursos.Tables[0].WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");
                this._dataSetAlumnos_Cursos.Tables[0].WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.XML");
            }
            else
            {
                   DataTable dtCursos = new DataTable("dtCursos");

                    dtCursos.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory +"\\CursosEsquema.XML");
                    dtCursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.XML");

                    this._dataSetAlumnos_Cursos.Tables.Add(dtCursos);

                    


            }

        }
    
    
    
    }
}
