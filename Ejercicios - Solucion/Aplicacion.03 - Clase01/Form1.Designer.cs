namespace Aplicacion._03
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblString = new System.Windows.Forms.Label();
            this.lblReverse = new System.Windows.Forms.Label();
            this.lblAlphabetic = new System.Windows.Forms.Label();
            this.txtAlfabetico = new System.Windows.Forms.TextBox();
            this.txtInvertida = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(43, 54);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(138, 13);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "Ingrese la cadena a invertir:";
            // 
            // lblReverse
            // 
            this.lblReverse.AutoSize = true;
            this.lblReverse.Location = new System.Drawing.Point(91, 93);
            this.lblReverse.Name = "lblReverse";
            this.lblReverse.Size = new System.Drawing.Size(90, 13);
            this.lblReverse.TabIndex = 1;
            this.lblReverse.Text = "Cadena invertida:";
            // 
            // lblAlphabetic
            // 
            this.lblAlphabetic.AutoSize = true;
            this.lblAlphabetic.Location = new System.Drawing.Point(89, 133);
            this.lblAlphabetic.Name = "lblAlphabetic";
            this.lblAlphabetic.Size = new System.Drawing.Size(92, 13);
            this.lblAlphabetic.TabIndex = 2;
            this.lblAlphabetic.Text = "Orden Alfabetico: ";
            // 
            // txtAlfabetico
            // 
            this.txtAlfabetico.Location = new System.Drawing.Point(191, 130);
            this.txtAlfabetico.Name = "txtAlfabetico";
            this.txtAlfabetico.Size = new System.Drawing.Size(100, 20);
            this.txtAlfabetico.TabIndex = 3;
            // 
            // txtInvertida
            // 
            this.txtInvertida.Location = new System.Drawing.Point(192, 90);
            this.txtInvertida.Name = "txtInvertida";
            this.txtInvertida.Size = new System.Drawing.Size(100, 20);
            this.txtInvertida.TabIndex = 4;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(192, 51);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(300, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(184, 173);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(69, 173);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 8;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtInvertida);
            this.Controls.Add(this.txtAlfabetico);
            this.Controls.Add(this.lblAlphabetic);
            this.Controls.Add(this.lblReverse);
            this.Controls.Add(this.lblString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Manejo de Cadenas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblReverse;
        private System.Windows.Forms.Label lblAlphabetic;
        private System.Windows.Forms.TextBox txtAlfabetico;
        private System.Windows.Forms.TextBox txtInvertida;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
    }
}

