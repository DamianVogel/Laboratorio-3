namespace _01TipoForms.Herencia.Menu
{
    partial class frmAnclar
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
            this.Button1 = new System.Windows.Forms.Button();
            this.btnAnclado = new System.Windows.Forms.Button();
            this.btnNoAnclado = new System.Windows.Forms.Button();
            this.grpAnclado = new System.Windows.Forms.GroupBox();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpNoAnclado = new System.Windows.Forms.GroupBox();
            this.grpAnclado.SuspendLayout();
            this.grpNoAnclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button1.Location = new System.Drawing.Point(0, 244);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(289, 23);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Dock";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // btnAnclado
            // 
            this.btnAnclado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnclado.Location = new System.Drawing.Point(79, 57);
            this.btnAnclado.Name = "btnAnclado";
            this.btnAnclado.Size = new System.Drawing.Size(75, 30);
            this.btnAnclado.TabIndex = 1;
            this.btnAnclado.Text = "Anclado";
            this.btnAnclado.UseVisualStyleBackColor = true;
            // 
            // btnNoAnclado
            // 
            this.btnNoAnclado.Location = new System.Drawing.Point(79, 19);
            this.btnNoAnclado.Name = "btnNoAnclado";
            this.btnNoAnclado.Size = new System.Drawing.Size(75, 23);
            this.btnNoAnclado.TabIndex = 0;
            this.btnNoAnclado.Text = "No Anclado";
            this.btnNoAnclado.UseVisualStyleBackColor = true;
            // 
            // grpAnclado
            // 
            this.grpAnclado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAnclado.Controls.Add(this.btnAnclado);
            this.grpAnclado.Controls.Add(this.btnNoAnclado);
            this.grpAnclado.Location = new System.Drawing.Point(37, 132);
            this.grpAnclado.Margin = new System.Windows.Forms.Padding(12, 3, 15, 3);
            this.grpAnclado.Name = "grpAnclado";
            this.grpAnclado.Size = new System.Drawing.Size(231, 107);
            this.grpAnclado.TabIndex = 3;
            this.grpAnclado.TabStop = false;
            this.grpAnclado.Text = "Anclado";
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(116, 39);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 20);
            this.TxtDato.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 39);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // grpNoAnclado
            // 
            this.grpNoAnclado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpNoAnclado.Controls.Add(this.TxtDato);
            this.grpNoAnclado.Controls.Add(this.btnAceptar);
            this.grpNoAnclado.Location = new System.Drawing.Point(37, 8);
            this.grpNoAnclado.Name = "grpNoAnclado";
            this.grpNoAnclado.Padding = new System.Windows.Forms.Padding(12);
            this.grpNoAnclado.Size = new System.Drawing.Size(231, 100);
            this.grpNoAnclado.TabIndex = 4;
            this.grpNoAnclado.TabStop = false;
            this.grpNoAnclado.Text = "No anclado \"Margin\"-\"Padding\"";
            // 
            // frmAnclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 267);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.grpAnclado);
            this.Controls.Add(this.grpNoAnclado);
            this.Name = "frmAnclar";
            this.Text = "frmAnclar";
            this.grpAnclado.ResumeLayout(false);
            this.grpNoAnclado.ResumeLayout(false);
            this.grpNoAnclado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnAnclado;
        internal System.Windows.Forms.Button btnNoAnclado;
        internal System.Windows.Forms.GroupBox grpAnclado;
        internal System.Windows.Forms.TextBox TxtDato;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.GroupBox grpNoAnclado;
    }
}