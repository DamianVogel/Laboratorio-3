namespace Ejercio_Matricula
{
    partial class Mostrar
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
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.btnAños = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(12, 62);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(471, 303);
            this.lstMostrar.TabIndex = 1;
            // 
            // btnAños
            // 
            this.btnAños.Location = new System.Drawing.Point(6, 419);
            this.btnAños.Name = "btnAños";
            this.btnAños.Size = new System.Drawing.Size(162, 23);
            this.btnAños.TabIndex = 2;
            this.btnAños.Text = "Alumnos > 2 años";
            this.btnAños.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filtrar por Localidad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(196, 459);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar Alumnos por Curso";
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAños);
            this.Controls.Add(this.lstMostrar);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.Button btnAños;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label1;
    }
}