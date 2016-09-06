namespace WindowsFormsApplication7
{
    partial class DemoMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hijo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hijo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hijo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.mosaicoHorizontalToolStripMenuItem,
            this.mosaicoVerticalToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hijo1ToolStripMenuItem,
            this.hijo2ToolStripMenuItem,
            this.hijo3ToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // hijo1ToolStripMenuItem
            // 
            this.hijo1ToolStripMenuItem.Name = "hijo1ToolStripMenuItem";
            this.hijo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hijo1ToolStripMenuItem.Text = "Hijo1";
            this.hijo1ToolStripMenuItem.Click += new System.EventHandler(this.hijo1ToolStripMenuItem_Click);
            // 
            // hijo2ToolStripMenuItem
            // 
            this.hijo2ToolStripMenuItem.Name = "hijo2ToolStripMenuItem";
            this.hijo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hijo2ToolStripMenuItem.Text = "Hijo2";
            this.hijo2ToolStripMenuItem.Click += new System.EventHandler(this.hijo2ToolStripMenuItem_Click);
            // 
            // hijo3ToolStripMenuItem
            // 
            this.hijo3ToolStripMenuItem.Name = "hijo3ToolStripMenuItem";
            this.hijo3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hijo3ToolStripMenuItem.Text = "Hijo3";
            this.hijo3ToolStripMenuItem.Click += new System.EventHandler(this.hijo3ToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // mosaicoHorizontalToolStripMenuItem
            // 
            this.mosaicoHorizontalToolStripMenuItem.Name = "mosaicoHorizontalToolStripMenuItem";
            this.mosaicoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.mosaicoHorizontalToolStripMenuItem.Text = "Mosaico Horizontal";
            this.mosaicoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_Click);
            // 
            // mosaicoVerticalToolStripMenuItem
            // 
            this.mosaicoVerticalToolStripMenuItem.Name = "mosaicoVerticalToolStripMenuItem";
            this.mosaicoVerticalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.mosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical";
            this.mosaicoVerticalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_Click);
            // 
            // DemoMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 489);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DemoMDI";
            this.Text = "Uso de MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hijo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hijo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hijo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoVerticalToolStripMenuItem;
    }
}

