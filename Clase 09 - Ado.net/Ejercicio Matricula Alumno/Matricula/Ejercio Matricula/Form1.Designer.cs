namespace Ejercio_Matricula
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.grpLocalidad = new System.Windows.Forms.GroupBox();
            this.lstLocalidad = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.grpLocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.rdbMasculino);
            this.grpDatos.Controls.Add(this.rdbFemenino);
            this.grpDatos.Controls.Add(this.txtLocalidad);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtAlumno);
            this.grpDatos.Controls.Add(this.txtFecha);
            this.grpDatos.Controls.Add(this.txtCurso);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(376, 247);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Ingreso de datos";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(252, 137);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 12;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(115, 139);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 11;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(115, 209);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(255, 20);
            this.txtLocalidad.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 174);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(255, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(115, 102);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(255, 20);
            this.txtAlumno.TabIndex = 8;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(115, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(115, 25);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(255, 20);
            this.txtCurso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btnSalir);
            this.grpOpciones.Controls.Add(this.btnLimpiar);
            this.grpOpciones.Controls.Add(this.btnGuardar);
            this.grpOpciones.Location = new System.Drawing.Point(394, 12);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(200, 247);
            this.grpOpciones.TabIndex = 1;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(40, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(40, 101);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 53);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(40, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 52);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.lstCursos);
            this.grpCursos.Location = new System.Drawing.Point(12, 275);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(282, 266);
            this.grpCursos.TabIndex = 1;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(19, 37);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(257, 212);
            this.lstCursos.TabIndex = 1;
            // 
            // grpLocalidad
            // 
            this.grpLocalidad.Controls.Add(this.lstLocalidad);
            this.grpLocalidad.Location = new System.Drawing.Point(311, 275);
            this.grpLocalidad.Name = "grpLocalidad";
            this.grpLocalidad.Size = new System.Drawing.Size(269, 266);
            this.grpLocalidad.TabIndex = 1;
            this.grpLocalidad.TabStop = false;
            this.grpLocalidad.Text = "Localidad";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(6, 37);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(257, 212);
            this.lstLocalidad.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(607, 24);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(118, 500);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 598);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grpLocalidad);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grpDatos);
            this.Name = "FrmPrincipal";
            this.Text = "Ingreso de Matricula";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            this.grpCursos.ResumeLayout(false);
            this.grpLocalidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.GroupBox grpLocalidad;
        private System.Windows.Forms.ListBox lstLocalidad;
        private System.Windows.Forms.Button btnMostrar;
    }
}

