namespace ControlesDeUsuario
{
    partial class UsrAlarma
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rdoFechaHoraAlarma = new System.Windows.Forms.RadioButton();
            this.rdoFechaHoraActual = new System.Windows.Forms.RadioButton();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblControlAlarma = new System.Windows.Forms.Label();
            this.txtFechaValidaExt1 = new ControlesDeUsuario.txtFechaValidaExt();
            this.SuspendLayout();
            // 
            // rdoFechaHoraAlarma
            // 
            this.rdoFechaHoraAlarma.AutoSize = true;
            this.rdoFechaHoraAlarma.Location = new System.Drawing.Point(160, 27);
            this.rdoFechaHoraAlarma.Name = "rdoFechaHoraAlarma";
            this.rdoFechaHoraAlarma.Size = new System.Drawing.Size(116, 17);
            this.rdoFechaHoraAlarma.TabIndex = 1;
            this.rdoFechaHoraAlarma.Text = "Fecha Hora Alarma";
            this.rdoFechaHoraAlarma.UseVisualStyleBackColor = true;
            this.rdoFechaHoraAlarma.CheckedChanged += new System.EventHandler(this.rdoFechaHoraAlarma_CheckedChanged);
            // 
            // rdoFechaHoraActual
            // 
            this.rdoFechaHoraActual.AutoSize = true;
            this.rdoFechaHoraActual.Checked = true;
            this.rdoFechaHoraActual.Location = new System.Drawing.Point(160, 50);
            this.rdoFechaHoraActual.Name = "rdoFechaHoraActual";
            this.rdoFechaHoraActual.Size = new System.Drawing.Size(114, 17);
            this.rdoFechaHoraActual.TabIndex = 2;
            this.rdoFechaHoraActual.TabStop = true;
            this.rdoFechaHoraActual.Text = "Fecha Hora Actual";
            this.rdoFechaHoraActual.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(49, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(88, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblControlAlarma
            // 
            this.lblControlAlarma.AutoSize = true;
            this.lblControlAlarma.Location = new System.Drawing.Point(16, 11);
            this.lblControlAlarma.Name = "lblControlAlarma";
            this.lblControlAlarma.Size = new System.Drawing.Size(75, 13);
            this.lblControlAlarma.TabIndex = 6;
            this.lblControlAlarma.Text = "Control Alarma";
            // 
            // txtFechaValidaExt1
            // 
            this.txtFechaValidaExt1.FormatoFecha = ControlesDeUsuario.eFormato.FormatoLatino;
            this.txtFechaValidaExt1.Location = new System.Drawing.Point(19, 27);
            this.txtFechaValidaExt1.Name = "txtFechaValidaExt1";
            this.txtFechaValidaExt1.Size = new System.Drawing.Size(124, 20);
            this.txtFechaValidaExt1.TabIndex = 3;
            this.txtFechaValidaExt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsrAlarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblControlAlarma);
            this.Controls.Add(this.txtFechaValidaExt1);
            this.Controls.Add(this.rdoFechaHoraActual);
            this.Controls.Add(this.rdoFechaHoraAlarma);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Name = "UsrAlarma";
            this.Size = new System.Drawing.Size(299, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFechaHoraAlarma;
        private System.Windows.Forms.RadioButton rdoFechaHoraActual;
        private System.Windows.Forms.Timer tmrTimer;
        private txtFechaValidaExt txtFechaValidaExt1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblControlAlarma;
    }
}
