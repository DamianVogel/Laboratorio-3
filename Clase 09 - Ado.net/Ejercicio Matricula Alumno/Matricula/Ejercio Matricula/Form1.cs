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
    public delegate DataSet DataSetDelegado (DataSet dataset);


    public partial class FrmPrincipal : Form
    {

        public DataSet dsInscripcion;
        public DataTable dtMatricula;
        public DataTable dtCurso;
        public DataTable dtLocalidad;

        

        public DataSetDelegado miDelegado;

        
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

            #region Datatables
            /*----DATATABLE MATRICULA----*/

            this.dtMatricula.Columns.Add("IdCurso",typeof(Int32));
            this.dtMatricula.Columns.Add("Fecha",typeof(String));
            this.dtMatricula.Columns.Add("Apellido", typeof(String));
            this.dtMatricula.Columns.Add("Sexo", typeof(String));
            this.dtMatricula.Columns.Add("Direccion", typeof(String));
            this.dtMatricula.Columns.Add("IdLocalidad", typeof(Int32));


            /*----DATATABLE CURSOS----*/

            this.dtCurso.Columns.Add("codCurso", typeof(Int32));
            this.dtCurso.Columns.Add("Descripcion", typeof(String));

            this.dtCurso.PrimaryKey = new DataColumn[] {this.dtCurso.Columns["codCurso"]};

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

            this.dtLocalidad.PrimaryKey = new DataColumn[] { this.dtLocalidad.Columns["codLocalidad"] };

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

            #endregion

            #region Relations

            

            #endregion

            /* CARGO LOS LIST BOXs */

            foreach (DataRow row in this.dtCurso.Rows)
            {
                this.lstCursos.Items.Add(row["Descripcion"].ToString());
            }

            foreach (DataRow row in this.dtLocalidad.Rows)
            {
                this.lstLocalidad.Items.Add(row["Descripcion"].ToString());
            }

            

            
            this.lstCursos.SelectedIndexChanged += this.CambiarCurso;
            this.lstLocalidad.SelectedIndexChanged += this.CambiarLocalidad;
            this.btnLimpiar.Click += this.LimpiarTabla;
            this.FormClosing += this.Salir;

            DataRelation matriculaCurso = new DataRelation("MatriculaCurso", this.dtCurso.Columns["codCurso"], this.dtMatricula.Columns["Curso"]);
            DataRelation matriculaLocalidad = new DataRelation("MatriculaLocalidad", this.dtCurso.Columns["codLocalidad"], this.dtMatricula.Columns["Localidad"]);

            this.dsInscripcion.Relations.Add(matriculaCurso);
            this.dsInscripcion.Relations.Add(matriculaLocalidad);
            
        
        }


        private void CambiarCurso(object sender, EventArgs e)
        {
            this.txtCurso.Text = (String)this.lstCursos.SelectedItem;
        }

        private void CambiarLocalidad(object sender, EventArgs e)
        {
            this.txtLocalidad.Text = (String)this.lstLocalidad.SelectedItem;
        }

        private void LimpiarTabla(object sender, EventArgs e)
        {
            foreach (Control control in this.grpDatos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            
            }

            this.rdbFemenino.Checked = false;
            this.rdbMasculino.Checked = false;
        
        }

        private void Salir(object sender, FormClosingEventArgs e)
        {
           DialogResult respuesta = MessageBox.Show("Realmente desea salir???", "Exit", MessageBoxButtons.YesNo);

           if (respuesta == System.Windows.Forms.DialogResult.No)
           {
               e.Cancel = true;
           }
           else
               e.Cancel = false;
         

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataRow rowInscripcion = this.dtMatricula.NewRow();

            rowInscripcion["IdCurso"] = this.lstCursos.SelectedIndex;
            rowInscripcion["Fecha"] = this.txtFecha.Text;
            rowInscripcion["Apellido"] = this.txtAlumno.Text;

            if (this.rdbFemenino.Checked == true)
            {
                rowInscripcion["Sexo"] = this.rdbFemenino.ToString();
            }
            else if (this.rdbMasculino.Checked == true)
            {
                rowInscripcion["Sexo"] = this.rdbFemenino.ToString();
            }
            else
                rowInscripcion["Sexo"] = "Indefinido";

            rowInscripcion["IdLocalidad"] = this.lstLocalidad.SelectedIndex;

            this.dtMatricula.Rows.Add(rowInscripcion);

            this.LimpiarTabla(sender, e);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar frmMostrar = new Mostrar();

            frmMostrar.Show(this);




        }

        
        



    }
}
