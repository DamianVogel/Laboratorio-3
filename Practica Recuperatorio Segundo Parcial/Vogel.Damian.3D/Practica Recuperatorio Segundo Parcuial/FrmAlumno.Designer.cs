﻿namespace Practica_Recuperatorio_Segundo_Parcuial
{
    partial class FrmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbDatosDelAlumno = new System.Windows.Forms.GroupBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpbDatosDelAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDatosDelAlumno
            // 
            this.grpbDatosDelAlumno.Controls.Add(this.cmbCurso);
            this.grpbDatosDelAlumno.Controls.Add(this.txtLegajo);
            this.grpbDatosDelAlumno.Controls.Add(this.txtApellido);
            this.grpbDatosDelAlumno.Controls.Add(this.lblCurso);
            this.grpbDatosDelAlumno.Controls.Add(this.lblLegajo);
            this.grpbDatosDelAlumno.Controls.Add(this.lblApellido);
            this.grpbDatosDelAlumno.Location = new System.Drawing.Point(12, 12);
            this.grpbDatosDelAlumno.Name = "grpbDatosDelAlumno";
            this.grpbDatosDelAlumno.Size = new System.Drawing.Size(273, 247);
            this.grpbDatosDelAlumno.TabIndex = 0;
            this.grpbDatosDelAlumno.TabStop = false;
            this.grpbDatosDelAlumno.Text = "Datos del Alumno";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(47, 200);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(192, 21);
            this.cmbCurso.TabIndex = 5;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(47, 133);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(192, 20);
            this.txtLegajo.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(47, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(44, 174);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(44, 104);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(44, 44);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(59, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpbDatosDelAlumno);
            this.Name = "FrmAlumno";
            this.Text = "FrmAlumno";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            this.grpbDatosDelAlumno.ResumeLayout(false);
            this.grpbDatosDelAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDatosDelAlumno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        protected internal System.Windows.Forms.ComboBox cmbCurso;
        protected internal System.Windows.Forms.TextBox txtLegajo;
        protected internal System.Windows.Forms.TextBox txtApellido;
    }
}