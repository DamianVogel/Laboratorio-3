namespace Ejercicio_GetParent_GetChild_Select
{
    partial class FrmPrincipal
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
            this.grpInicializacion = new System.Windows.Forms.GroupBox();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.btnCargarLocalidades = new System.Windows.Forms.Button();
            this.btnCrearRelaciones = new System.Windows.Forms.Button();
            this.btnCrearSetTable = new System.Windows.Forms.Button();
            this.grpMostrar = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnMosProvLocalidadFiltro = new System.Windows.Forms.Button();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.btnMosProvLocalidadQuilmes = new System.Windows.Forms.Button();
            this.btnMosProdProvLocalidad = new System.Windows.Forms.Button();
            this.btnMosProvLocalidad = new System.Windows.Forms.Button();
            this.btnMosProdProveedor = new System.Windows.Forms.Button();
            this.grpInicializacion.SuspendLayout();
            this.grpMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInicializacion
            // 
            this.grpInicializacion.Controls.Add(this.btnCargarProductos);
            this.grpInicializacion.Controls.Add(this.btnCargarProveedores);
            this.grpInicializacion.Controls.Add(this.btnCargarLocalidades);
            this.grpInicializacion.Controls.Add(this.btnCrearRelaciones);
            this.grpInicializacion.Controls.Add(this.btnCrearSetTable);
            this.grpInicializacion.Location = new System.Drawing.Point(23, 12);
            this.grpInicializacion.Name = "grpInicializacion";
            this.grpInicializacion.Size = new System.Drawing.Size(211, 418);
            this.grpInicializacion.TabIndex = 0;
            this.grpInicializacion.TabStop = false;
            this.grpInicializacion.Text = "Inicializacion";
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(27, 288);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(153, 49);
            this.btnCargarProductos.TabIndex = 4;
            this.btnCargarProductos.Text = "Cargar Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.Location = new System.Drawing.Point(27, 222);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(153, 45);
            this.btnCargarProveedores.TabIndex = 3;
            this.btnCargarProveedores.Text = "Cargar Proveedores";
            this.btnCargarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCargarLocalidades
            // 
            this.btnCargarLocalidades.Location = new System.Drawing.Point(27, 160);
            this.btnCargarLocalidades.Name = "btnCargarLocalidades";
            this.btnCargarLocalidades.Size = new System.Drawing.Size(153, 43);
            this.btnCargarLocalidades.TabIndex = 2;
            this.btnCargarLocalidades.Text = "Cargar Localidades";
            this.btnCargarLocalidades.UseVisualStyleBackColor = true;
            // 
            // btnCrearRelaciones
            // 
            this.btnCrearRelaciones.Location = new System.Drawing.Point(27, 98);
            this.btnCrearRelaciones.Name = "btnCrearRelaciones";
            this.btnCrearRelaciones.Size = new System.Drawing.Size(153, 41);
            this.btnCrearRelaciones.TabIndex = 1;
            this.btnCrearRelaciones.Text = "Crear Relaciones";
            this.btnCrearRelaciones.UseVisualStyleBackColor = true;
            this.btnCrearRelaciones.Click += new System.EventHandler(this.btnCrearRelaciones_Click);
            // 
            // btnCrearSetTable
            // 
            this.btnCrearSetTable.Location = new System.Drawing.Point(27, 35);
            this.btnCrearSetTable.Name = "btnCrearSetTable";
            this.btnCrearSetTable.Size = new System.Drawing.Size(153, 46);
            this.btnCrearSetTable.TabIndex = 0;
            this.btnCrearSetTable.Text = "Crear Data Set y Data Table";
            this.btnCrearSetTable.UseVisualStyleBackColor = true;
            this.btnCrearSetTable.Click += new System.EventHandler(this.btnCrearSetTable_Click);
            // 
            // grpMostrar
            // 
            this.grpMostrar.Controls.Add(this.txtFiltro);
            this.grpMostrar.Controls.Add(this.btnMosProvLocalidadFiltro);
            this.grpMostrar.Controls.Add(this.lstMostrar);
            this.grpMostrar.Controls.Add(this.btnMosProvLocalidadQuilmes);
            this.grpMostrar.Controls.Add(this.btnMosProdProvLocalidad);
            this.grpMostrar.Controls.Add(this.btnMosProvLocalidad);
            this.grpMostrar.Controls.Add(this.btnMosProdProveedor);
            this.grpMostrar.Location = new System.Drawing.Point(251, 12);
            this.grpMostrar.Name = "grpMostrar";
            this.grpMostrar.Size = new System.Drawing.Size(424, 417);
            this.grpMostrar.TabIndex = 1;
            this.grpMostrar.TabStop = false;
            this.grpMostrar.Text = "Mostrar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(221, 365);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(194, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // btnMosProvLocalidadFiltro
            // 
            this.btnMosProvLocalidadFiltro.Location = new System.Drawing.Point(15, 365);
            this.btnMosProvLocalidadFiltro.Name = "btnMosProvLocalidadFiltro";
            this.btnMosProvLocalidadFiltro.Size = new System.Drawing.Size(200, 46);
            this.btnMosProvLocalidadFiltro.TabIndex = 5;
            this.btnMosProvLocalidadFiltro.Text = "Mostrar Proveedores de la localidad del Txtfiltro";
            this.btnMosProvLocalidadFiltro.UseVisualStyleBackColor = true;
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(15, 132);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(400, 225);
            this.lstMostrar.TabIndex = 4;
            // 
            // btnMosProvLocalidadQuilmes
            // 
            this.btnMosProvLocalidadQuilmes.Location = new System.Drawing.Point(216, 75);
            this.btnMosProvLocalidadQuilmes.Name = "btnMosProvLocalidadQuilmes";
            this.btnMosProvLocalidadQuilmes.Size = new System.Drawing.Size(200, 46);
            this.btnMosProvLocalidadQuilmes.TabIndex = 3;
            this.btnMosProvLocalidadQuilmes.Text = "4-Mostrar Proveedores de la Localidad \"Quilmes\"";
            this.btnMosProvLocalidadQuilmes.UseVisualStyleBackColor = true;
            // 
            // btnMosProdProvLocalidad
            // 
            this.btnMosProdProvLocalidad.Location = new System.Drawing.Point(15, 75);
            this.btnMosProdProvLocalidad.Name = "btnMosProdProvLocalidad";
            this.btnMosProdProvLocalidad.Size = new System.Drawing.Size(200, 46);
            this.btnMosProdProvLocalidad.TabIndex = 2;
            this.btnMosProdProvLocalidad.Text = "3-Mostrar Productos con Proveedor con su Localidad";
            this.btnMosProdProvLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMosProvLocalidad
            // 
            this.btnMosProvLocalidad.Location = new System.Drawing.Point(216, 19);
            this.btnMosProvLocalidad.Name = "btnMosProvLocalidad";
            this.btnMosProvLocalidad.Size = new System.Drawing.Size(200, 46);
            this.btnMosProvLocalidad.TabIndex = 1;
            this.btnMosProvLocalidad.Text = "2-Mostrar Proveedor con su localidad";
            this.btnMosProvLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMosProdProveedor
            // 
            this.btnMosProdProveedor.Location = new System.Drawing.Point(15, 19);
            this.btnMosProdProveedor.Name = "btnMosProdProveedor";
            this.btnMosProdProveedor.Size = new System.Drawing.Size(200, 46);
            this.btnMosProdProveedor.TabIndex = 0;
            this.btnMosProdProveedor.Text = "1-Mostrar Productos con su  Proveedor";
            this.btnMosProdProveedor.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 454);
            this.Controls.Add(this.grpMostrar);
            this.Controls.Add(this.grpInicializacion);
            this.Name = "FrmPrincipal";
            this.Text = "Ejercicio DataSet";
            this.grpInicializacion.ResumeLayout(false);
            this.grpMostrar.ResumeLayout(false);
            this.grpMostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInicializacion;
        private System.Windows.Forms.Button btnCargarProductos;
        private System.Windows.Forms.Button btnCargarProveedores;
        private System.Windows.Forms.Button btnCargarLocalidades;
        private System.Windows.Forms.Button btnCrearRelaciones;
        private System.Windows.Forms.Button btnCrearSetTable;
        private System.Windows.Forms.GroupBox grpMostrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnMosProvLocalidadFiltro;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.Button btnMosProvLocalidadQuilmes;
        private System.Windows.Forms.Button btnMosProdProvLocalidad;
        private System.Windows.Forms.Button btnMosProvLocalidad;
        private System.Windows.Forms.Button btnMosProdProveedor;
    }
}

