﻿namespace FrmPrincipal
{
    partial class FrmGestion
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "btnIngreso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEgreso
            // 
            this.btnEgreso.Location = new System.Drawing.Point(198, 396);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(75, 23);
            this.btnEgreso.TabIndex = 2;
            this.btnEgreso.Text = "btnEgreso";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(314, 396);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.Location = new System.Drawing.Point(83, 23);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(374, 329);
            this.lstMedicos.TabIndex = 0;
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(423, 396);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenamiento.TabIndex = 4;
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamiento_SelectedIndexChanged);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 443);
            this.Controls.Add(this.cmbOrdenamiento);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEgreso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstMedicos);
            this.Name = "FrmGestion";
            this.Text = "FrmGestion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
    }
}