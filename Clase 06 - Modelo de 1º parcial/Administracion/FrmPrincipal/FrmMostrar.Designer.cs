namespace FrmPrincipal
{
    partial class FrmMostrar
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
            this.listSalida = new System.Windows.Forms.ListBox();
            this.lstTrabajando = new System.Windows.Forms.ListBox();
            this.lblTrabajando = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSalida
            // 
            this.listSalida.FormattingEnabled = true;
            this.listSalida.Location = new System.Drawing.Point(312, 78);
            this.listSalida.Name = "listSalida";
            this.listSalida.Size = new System.Drawing.Size(179, 199);
            this.listSalida.TabIndex = 0;
            // 
            // lstTrabajando
            // 
            this.lstTrabajando.FormattingEnabled = true;
            this.lstTrabajando.Location = new System.Drawing.Point(74, 78);
            this.lstTrabajando.Name = "lstTrabajando";
            this.lstTrabajando.Size = new System.Drawing.Size(169, 199);
            this.lstTrabajando.TabIndex = 1;
            // 
            // lblTrabajando
            // 
            this.lblTrabajando.AutoSize = true;
            this.lblTrabajando.Location = new System.Drawing.Point(71, 60);
            this.lblTrabajando.Name = "lblTrabajando";
            this.lblTrabajando.Size = new System.Drawing.Size(61, 13);
            this.lblTrabajando.TabIndex = 2;
            this.lblTrabajando.Text = "Trabajando";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(309, 60);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Salida";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 380);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblTrabajando);
            this.Controls.Add(this.lstTrabajando);
            this.Controls.Add(this.listSalida);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSalida;
        private System.Windows.Forms.ListBox lstTrabajando;
        private System.Windows.Forms.Label lblTrabajando;
        private System.Windows.Forms.Label lblSalida;
    }
}