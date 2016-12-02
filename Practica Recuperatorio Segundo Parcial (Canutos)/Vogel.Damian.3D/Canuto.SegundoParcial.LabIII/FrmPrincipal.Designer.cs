namespace Canuto.SegundoParcial.LabIII
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.canutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconditesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canutosConEsconditesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canutosEnConventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canutoToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // canutoToolStripMenuItem
            // 
            this.canutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.modificacionToolStripMenuItem});
            this.canutoToolStripMenuItem.Name = "canutoToolStripMenuItem";
            this.canutoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.canutoToolStripMenuItem.Text = "Canuto";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canutosToolStripMenuItem,
            this.esconditesToolStripMenuItem,
            this.canutosConEsconditesToolStripMenuItem,
            this.canutosEnConventoToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bajasToolStripMenuItem.Text = "Baja";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // canutosToolStripMenuItem
            // 
            this.canutosToolStripMenuItem.Name = "canutosToolStripMenuItem";
            this.canutosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.canutosToolStripMenuItem.Text = "Canutos";
            this.canutosToolStripMenuItem.Click += new System.EventHandler(this.canutosToolStripMenuItem_Click);
            // 
            // esconditesToolStripMenuItem
            // 
            this.esconditesToolStripMenuItem.Name = "esconditesToolStripMenuItem";
            this.esconditesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.esconditesToolStripMenuItem.Text = "Escondites";
            this.esconditesToolStripMenuItem.Click += new System.EventHandler(this.esconditesToolStripMenuItem_Click);
            // 
            // canutosConEsconditesToolStripMenuItem
            // 
            this.canutosConEsconditesToolStripMenuItem.Name = "canutosConEsconditesToolStripMenuItem";
            this.canutosConEsconditesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.canutosConEsconditesToolStripMenuItem.Text = "Canutos con Escondites";
            this.canutosConEsconditesToolStripMenuItem.Click += new System.EventHandler(this.canutosConEsconditesToolStripMenuItem_Click);
            // 
            // canutosEnConventoToolStripMenuItem
            // 
            this.canutosEnConventoToolStripMenuItem.Name = "canutosEnConventoToolStripMenuItem";
            this.canutosEnConventoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.canutosEnConventoToolStripMenuItem.Text = "Canutos en Convento";
            this.canutosEnConventoToolStripMenuItem.Click += new System.EventHandler(this.canutosEnConventoToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem canutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconditesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canutosConEsconditesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canutosEnConventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}