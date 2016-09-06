namespace Aplicaicon3
{
    partial class frmManejoCadenas
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
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.lblInvertida = new System.Windows.Forms.Label();
            this.txtInvertida = new System.Windows.Forms.TextBox();
            this.lblOrdenada = new System.Windows.Forms.Label();
            this.txtOrdenada = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(96, 49);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(138, 13);
            this.lblCadena.TabIndex = 6;
            this.lblCadena.Text = "Ingrese la cadena a invertir:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(272, 46);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(159, 20);
            this.txtCadena.TabIndex = 0;
            // 
            // lblInvertida
            // 
            this.lblInvertida.AutoSize = true;
            this.lblInvertida.Location = new System.Drawing.Point(96, 88);
            this.lblInvertida.Name = "lblInvertida";
            this.lblInvertida.Size = new System.Drawing.Size(91, 13);
            this.lblInvertida.TabIndex = 8;
            this.lblInvertida.Text = "Cadena Invertida:";
            // 
            // txtInvertida
            // 
            this.txtInvertida.Location = new System.Drawing.Point(272, 87);
            this.txtInvertida.Name = "txtInvertida";
            this.txtInvertida.ReadOnly = true;
            this.txtInvertida.Size = new System.Drawing.Size(159, 20);
            this.txtInvertida.TabIndex = 10;
            this.txtInvertida.TabStop = false;
            // 
            // lblOrdenada
            // 
            this.lblOrdenada.AutoSize = true;
            this.lblOrdenada.Location = new System.Drawing.Point(96, 127);
            this.lblOrdenada.Name = "lblOrdenada";
            this.lblOrdenada.Size = new System.Drawing.Size(89, 13);
            this.lblOrdenada.TabIndex = 9;
            this.lblOrdenada.Text = "Orden Alfabetico:";
            // 
            // txtOrdenada
            // 
            this.txtOrdenada.Location = new System.Drawing.Point(272, 128);
            this.txtOrdenada.Name = "txtOrdenada";
            this.txtOrdenada.ReadOnly = true;
            this.txtOrdenada.Size = new System.Drawing.Size(159, 20);
            this.txtOrdenada.TabIndex = 11;
            this.txtOrdenada.TabStop = false;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(41, 216);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(134, 33);
            this.btnOperar.TabIndex = 1;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(193, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 33);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(345, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmManejoCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 261);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.lblInvertida);
            this.Controls.Add(this.txtInvertida);
            this.Controls.Add(this.lblOrdenada);
            this.Controls.Add(this.txtOrdenada);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmManejoCadenas";
            this.Text = "Manejo de Cadenas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManejoCadenas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label lblInvertida;
        private System.Windows.Forms.TextBox txtInvertida;
        private System.Windows.Forms.Label lblOrdenada;
        private System.Windows.Forms.TextBox txtOrdenada;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

