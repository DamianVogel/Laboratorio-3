namespace Aplicacion4
{
    partial class frmOrdenamiento
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
            this.grbNumero = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbOrden = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            this.grbLista = new System.Windows.Forms.GroupBox();
            this.lsbNumeros = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbNumero.SuspendLayout();
            this.grbOrden.SuspendLayout();
            this.grbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNumero
            // 
            this.grbNumero.Controls.Add(this.txtNumero);
            this.grbNumero.Controls.Add(this.btnAgregar);
            this.grbNumero.Location = new System.Drawing.Point(12, 12);
            this.grbNumero.Name = "grbNumero";
            this.grbNumero.Size = new System.Drawing.Size(310, 74);
            this.grbNumero.TabIndex = 0;
            this.grbNumero.TabStop = false;
            this.grbNumero.Text = "Ingresar un nuevo número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(23, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(175, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbOrden
            // 
            this.grbOrden.Controls.Add(this.btnOrdenar);
            this.grbOrden.Controls.Add(this.rdbAscendente);
            this.grbOrden.Controls.Add(this.rdbDescendente);
            this.grbOrden.Location = new System.Drawing.Point(12, 92);
            this.grbOrden.Name = "grbOrden";
            this.grbOrden.Size = new System.Drawing.Size(310, 157);
            this.grbOrden.TabIndex = 1;
            this.grbOrden.TabStop = false;
            this.grbOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(174, 59);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(121, 32);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Location = new System.Drawing.Point(47, 48);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rdbAscendente.TabIndex = 0;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(47, 89);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdbDescendente.TabIndex = 0;
            this.rdbDescendente.TabStop = true;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            // 
            // grbLista
            // 
            this.grbLista.Controls.Add(this.lsbNumeros);
            this.grbLista.Location = new System.Drawing.Point(328, 12);
            this.grbLista.Name = "grbLista";
            this.grbLista.Size = new System.Drawing.Size(257, 237);
            this.grbLista.TabIndex = 3;
            this.grbLista.TabStop = false;
            this.grbLista.Text = "Lista de Números";
            // 
            // lsbNumeros
            // 
            this.lsbNumeros.FormattingEnabled = true;
            this.lsbNumeros.Location = new System.Drawing.Point(6, 19);
            this.lsbNumeros.Name = "lsbNumeros";
            this.lsbNumeros.Size = new System.Drawing.Size(245, 212);
            this.lsbNumeros.TabIndex = 0;
            this.lsbNumeros.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(591, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 74);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmOrdenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 261);
            this.Controls.Add(this.grbNumero);
            this.Controls.Add(this.grbOrden);
            this.Controls.Add(this.grbLista);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmOrdenamiento";
            this.Text = "Ordenamiento por Burbujeo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenamiento_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenamiento_Load);
            this.grbNumero.ResumeLayout(false);
            this.grbNumero.PerformLayout();
            this.grbOrden.ResumeLayout(false);
            this.grbOrden.PerformLayout();
            this.grbLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox grbOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.RadioButton rdbAscendente;
        private System.Windows.Forms.GroupBox grbLista;
        private System.Windows.Forms.ListBox lsbNumeros;
        private System.Windows.Forms.Button btnSalir;
    }
}

