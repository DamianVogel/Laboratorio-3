namespace _01TipoForms.Herencia.Menu
{
    partial class frmMostrarConMenus
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
            this.lstLista = new System.Windows.Forms.ListBox();
            this.mnuMenuCerrar = new System.Windows.Forms.MenuStrip();
            this.CerrarMostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(12, 28);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(268, 238);
            this.lstLista.TabIndex = 2;
            // 
            // mnuMenuCerrar
            // 
            this.mnuMenuCerrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CerrarMostrarToolStripMenuItem});
            this.mnuMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuCerrar.Name = "mnuMenuCerrar";
            this.mnuMenuCerrar.Size = new System.Drawing.Size(299, 24);
            this.mnuMenuCerrar.TabIndex = 3;
            this.mnuMenuCerrar.Text = "MenuStrip1";
            // 
            // CerrarMostrarToolStripMenuItem
            // 
            this.CerrarMostrarToolStripMenuItem.Name = "CerrarMostrarToolStripMenuItem";
            this.CerrarMostrarToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.CerrarMostrarToolStripMenuItem.Text = "Cerrar Mostrar";
            this.CerrarMostrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarMostrarToolStripMenuItem_Click);
            // 
            // frmMostrarConMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 278);
            this.Controls.Add(this.mnuMenuCerrar);
            this.Controls.Add(this.lstLista);
            this.Name = "frmMostrarConMenus";
            this.Text = "frmMostrarConMenus";
            this.Load += new System.EventHandler(this.frmMostrarConMenus_Load);
            this.mnuMenuCerrar.ResumeLayout(false);
            this.mnuMenuCerrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstLista;
        internal System.Windows.Forms.MenuStrip mnuMenuCerrar;
        internal System.Windows.Forms.ToolStripMenuItem CerrarMostrarToolStripMenuItem;
    }
}