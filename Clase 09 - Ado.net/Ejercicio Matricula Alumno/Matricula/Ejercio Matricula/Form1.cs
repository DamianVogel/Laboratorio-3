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
    public partial class FrmPrincipal : Form
    {

        DataSet dsInscripcion;
        DataTable dtMatricula;
        DataTable dtCurso;
        DataTable dtLocalidad;
        



        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.dsInscripcion = new DataSet("Inscripcion");

            this.dtMatricula = new DataTable("Matricula");
            this.dtCurso = new DataTable("Curso");
            this.dtLocalidad = new DataTable("Localidad");


            /*----DATATABLE MATRICULA----*/

            this.dtMatricula.Columns.Add("IdCurso",typeof(Int32));
            this.dtMatricula.Columns.Add("Fecha",typeof(String));
            this.dtMatricula.Columns.Add("Apellido", typeof(String));
            this.dtMatricula.Columns.Add("Sexo", typeof(String));
            this.dtMatricula.Columns.Add("Direccion", typeof(String));
            this.dtMatricula.Columns.Add("Localidad", typeof(Int32));


            /*----DATATABLE CURSOS----*/

            this.dtCurso.Columns.Add("codCurso", typeof(Int32));
            this.dtCurso.Columns.Add("Descripcion", typeof(String));

            DataRow primerCurso = this.dtCurso.NewRow();

            primerCurso["codCurso"] = 1;
            primerCurso["Descripcion"] = "Borland C";

            this.dtCurso.Rows.Add(primerCurso);

            DataRow segundoCurso = this.dtCurso.NewRow();

            segundoCurso["codCurso"] = 2;
            segundoCurso["Descripcion"] = "Borland C++";

            this.dtCurso.Rows.Add(segundoCurso);

            DataRow tercerCurso = this.dtCurso.NewRow();

            tercerCurso["codCurso"] = 3;
            tercerCurso["Descripcion"] = "Microsoft C# (Sharp) Nivel I";

            this.dtCurso.Rows.Add(tercerCurso);

            DataRow cuartoCurso = this.dtCurso.NewRow();

            cuartoCurso["codCurso"] = 4;
            cuartoCurso["Descripcion"] = "Microsoft C# (Sharp) Nivel II";

            this.dtCurso.Rows.Add(cuartoCurso);

            DataRow quintoCurso = this.dtCurso.NewRow();

            quintoCurso["codCurso"] = 5;
            quintoCurso["Descripcion"] = "Microsoft Visual Basic .Net Nivel I";

            this.dtCurso.Rows.Add(quintoCurso);

            DataRow sextoCurso = this.dtCurso.NewRow();

            sextoCurso["codCurso"] = 6;
            sextoCurso["Descripcion"] = "Microsoft SQL Server 2008 Nivel II";

            this.dtCurso.Rows.Add(sextoCurso);

            DataRow septimoCurso = this.dtCurso.NewRow();

            septimoCurso["codCurso"] = 7;
            septimoCurso["Descripcion"] = "Java";

            this.dtCurso.Rows.Add(septimoCurso);


            /*----DATATABLE LOCALIDAD----*/

            this.dtLocalidad.Columns.Add("codLocalidad", typeof(Int32));
            this.dtLocalidad.Columns.Add("Descripcion", typeof(String));

            DataRow primeraLocalidad = this.dtLocalidad.NewRow();

            primeraLocalidad["codLocalidad"] = 1;
            primeraLocalidad["Descripcion"] = "Avellaneda";

            this.dtLocalidad.Rows.Add(primeraLocalidad);


            DataRow segundaLocalidad = this.dtLocalidad.NewRow();

            segundaLocalidad["codLocalidad"] = 2;
            segundaLocalidad["Descripcion"] = "Capital Federal";

            this.dtLocalidad.Rows.Add(segundaLocalidad);

            DataRow terceraLocalidad = this.dtLocalidad.NewRow();

            terceraLocalidad["codLocalidad"] = 3;
            terceraLocalidad["Descripcion"] = "Quilmes";

            this.dtLocalidad.Rows.Add(terceraLocalidad);


            DataRow cuartaLocalidad = this.dtLocalidad.NewRow();

            cuartaLocalidad["codLocalidad"] = 4;
            cuartaLocalidad["Descripcion"] = "Berazategui";

            this.dtLocalidad.Rows.Add(cuartaLocalidad);


            DataRow quintaLocalidad = this.dtLocalidad.NewRow();

            quintaLocalidad["codLocalidad"] = 5;
            quintaLocalidad["Descripcion"] = "Lanus";

            this.dtLocalidad.Rows.Add(quintaLocalidad);


































        }
   
    
    
    }
}
