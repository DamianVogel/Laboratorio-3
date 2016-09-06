namespace _02Recursos
{
    partial class frmRecursos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btnIcono = new System.Windows.Forms.Button();
            this.btnSonidos = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnFondo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIcono
            // 
            this.btnIcono.Location = new System.Drawing.Point(182, 145);
            this.btnIcono.Name = "btnIcono";
            this.btnIcono.Size = new System.Drawing.Size(99, 23);
            this.btnIcono.TabIndex = 7;
            this.btnIcono.Text = "Icono";
            this.btnIcono.UseVisualStyleBackColor = true;
            this.btnIcono.Click += new System.EventHandler(this.btnIcono_Click);
            // 
            // btnSonidos
            // 
            this.btnSonidos.Location = new System.Drawing.Point(13, 145);
            this.btnSonidos.Name = "btnSonidos";
            this.btnSonidos.Size = new System.Drawing.Size(99, 23);
            this.btnSonidos.TabIndex = 6;
            this.btnSonidos.Text = "Sonido";
            this.btnSonidos.UseVisualStyleBackColor = true;
            this.btnSonidos.Click += new System.EventHandler(this.btnSonidos_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(182, 94);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(99, 23);
            this.btnTexto.TabIndex = 5;
            this.btnTexto.Text = "Mostrar Texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnFondo
            // 
            this.btnFondo.Location = new System.Drawing.Point(13, 94);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(99, 23);
            this.btnFondo.TabIndex = 4;
            this.btnFondo.Text = "Imagen de Fondo";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // frmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.btnIcono);
            this.Controls.Add(this.btnSonidos);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.btnFondo);
            this.Name = "frmRecursos";
            this.Text = "Recursos";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnIcono;
        internal System.Windows.Forms.Button btnSonidos;
        internal System.Windows.Forms.Button btnTexto;
        internal System.Windows.Forms.Button btnFondo;
    }
}

