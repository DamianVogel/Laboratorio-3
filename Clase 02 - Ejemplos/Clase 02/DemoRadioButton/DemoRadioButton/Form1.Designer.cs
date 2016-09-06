namespace DemoRadioButton
{
    partial class frmPrincipal
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
            this.grpTipoBoton = new System.Windows.Forms.GroupBox();
            this.rdoRC = new System.Windows.Forms.RadioButton();
            this.rdoSN = new System.Windows.Forms.RadioButton();
            this.rdoSNC = new System.Windows.Forms.RadioButton();
            this.rdoARI = new System.Windows.Forms.RadioButton();
            this.rdoCancelar = new System.Windows.Forms.RadioButton();
            this.rdoAceptar = new System.Windows.Forms.RadioButton();
            this.grpIcono = new System.Windows.Forms.GroupBox();
            this.rdoAdvert = new System.Windows.Forms.RadioButton();
            this.rdoAlto = new System.Windows.Forms.RadioButton();
            this.rdoPregunta = new System.Windows.Forms.RadioButton();
            this.rdoInfor = new System.Windows.Forms.RadioButton();
            this.rdoMano = new System.Windows.Forms.RadioButton();
            this.rdoExclamacion = new System.Windows.Forms.RadioButton();
            this.rdoError = new System.Windows.Forms.RadioButton();
            this.rdoAsterisco = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMostar = new System.Windows.Forms.Label();
            this.grpTipoBoton.SuspendLayout();
            this.grpIcono.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoBoton
            // 
            this.grpTipoBoton.Controls.Add(this.rdoRC);
            this.grpTipoBoton.Controls.Add(this.rdoSN);
            this.grpTipoBoton.Controls.Add(this.rdoSNC);
            this.grpTipoBoton.Controls.Add(this.rdoARI);
            this.grpTipoBoton.Controls.Add(this.rdoCancelar);
            this.grpTipoBoton.Controls.Add(this.rdoAceptar);
            this.grpTipoBoton.Location = new System.Drawing.Point(12, 12);
            this.grpTipoBoton.Name = "grpTipoBoton";
            this.grpTipoBoton.Size = new System.Drawing.Size(226, 281);
            this.grpTipoBoton.TabIndex = 0;
            this.grpTipoBoton.TabStop = false;
            this.grpTipoBoton.Text = "Tipo de Botón";
            // 
            // rdoRC
            // 
            this.rdoRC.AutoSize = true;
            this.rdoRC.Location = new System.Drawing.Point(30, 232);
            this.rdoRC.Name = "rdoRC";
            this.rdoRC.Size = new System.Drawing.Size(116, 17);
            this.rdoRC.TabIndex = 5;
            this.rdoRC.TabStop = true;
            this.rdoRC.Text = "ReintentarCancelar";
            this.rdoRC.UseVisualStyleBackColor = true;
            this.rdoRC.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // rdoSN
            // 
            this.rdoSN.AutoSize = true;
            this.rdoSN.Location = new System.Drawing.Point(30, 192);
            this.rdoSN.Name = "rdoSN";
            this.rdoSN.Size = new System.Drawing.Size(48, 17);
            this.rdoSN.TabIndex = 4;
            this.rdoSN.TabStop = true;
            this.rdoSN.Text = "SiNo";
            this.rdoSN.UseVisualStyleBackColor = true;
            this.rdoSN.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // rdoSNC
            // 
            this.rdoSNC.AutoSize = true;
            this.rdoSNC.Location = new System.Drawing.Point(30, 152);
            this.rdoSNC.Name = "rdoSNC";
            this.rdoSNC.Size = new System.Drawing.Size(90, 17);
            this.rdoSNC.TabIndex = 3;
            this.rdoSNC.TabStop = true;
            this.rdoSNC.Text = "SiNoCancelar";
            this.rdoSNC.UseVisualStyleBackColor = true;
            this.rdoSNC.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // rdoARI
            // 
            this.rdoARI.AutoSize = true;
            this.rdoARI.Location = new System.Drawing.Point(30, 112);
            this.rdoARI.Name = "rdoARI";
            this.rdoARI.Size = new System.Drawing.Size(141, 17);
            this.rdoARI.TabIndex = 2;
            this.rdoARI.TabStop = true;
            this.rdoARI.Text = "AbortarReintentarIgnorar";
            this.rdoARI.UseVisualStyleBackColor = true;
            this.rdoARI.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // rdoCancelar
            // 
            this.rdoCancelar.AutoSize = true;
            this.rdoCancelar.Location = new System.Drawing.Point(30, 72);
            this.rdoCancelar.Name = "rdoCancelar";
            this.rdoCancelar.Size = new System.Drawing.Size(104, 17);
            this.rdoCancelar.TabIndex = 1;
            this.rdoCancelar.TabStop = true;
            this.rdoCancelar.Text = "AceptarCancelar";
            this.rdoCancelar.UseVisualStyleBackColor = true;
            this.rdoCancelar.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // rdoAceptar
            // 
            this.rdoAceptar.AutoSize = true;
            this.rdoAceptar.Location = new System.Drawing.Point(30, 32);
            this.rdoAceptar.Name = "rdoAceptar";
            this.rdoAceptar.Size = new System.Drawing.Size(62, 17);
            this.rdoAceptar.TabIndex = 0;
            this.rdoAceptar.TabStop = true;
            this.rdoAceptar.Text = "Aceptar";
            this.rdoAceptar.UseVisualStyleBackColor = true;
            this.rdoAceptar.CheckedChanged += new System.EventHandler(this.rdoAceptar_CheckedChanged);
            // 
            // grpIcono
            // 
            this.grpIcono.Controls.Add(this.rdoAdvert);
            this.grpIcono.Controls.Add(this.rdoAlto);
            this.grpIcono.Controls.Add(this.rdoPregunta);
            this.grpIcono.Controls.Add(this.rdoInfor);
            this.grpIcono.Controls.Add(this.rdoMano);
            this.grpIcono.Controls.Add(this.rdoExclamacion);
            this.grpIcono.Controls.Add(this.rdoError);
            this.grpIcono.Controls.Add(this.rdoAsterisco);
            this.grpIcono.Location = new System.Drawing.Point(257, 12);
            this.grpIcono.Name = "grpIcono";
            this.grpIcono.Size = new System.Drawing.Size(200, 382);
            this.grpIcono.TabIndex = 0;
            this.grpIcono.TabStop = false;
            this.grpIcono.Text = "Icono";
            // 
            // rdoAdvert
            // 
            this.rdoAdvert.AutoSize = true;
            this.rdoAdvert.Location = new System.Drawing.Point(25, 333);
            this.rdoAdvert.Name = "rdoAdvert";
            this.rdoAdvert.Size = new System.Drawing.Size(82, 17);
            this.rdoAdvert.TabIndex = 7;
            this.rdoAdvert.TabStop = true;
            this.rdoAdvert.Text = "Advertencia";
            this.rdoAdvert.UseVisualStyleBackColor = true;
            this.rdoAdvert.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoAlto
            // 
            this.rdoAlto.AutoSize = true;
            this.rdoAlto.Location = new System.Drawing.Point(25, 290);
            this.rdoAlto.Name = "rdoAlto";
            this.rdoAlto.Size = new System.Drawing.Size(43, 17);
            this.rdoAlto.TabIndex = 6;
            this.rdoAlto.TabStop = true;
            this.rdoAlto.Text = "Alto";
            this.rdoAlto.UseVisualStyleBackColor = true;
            this.rdoAlto.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoPregunta
            // 
            this.rdoPregunta.AutoSize = true;
            this.rdoPregunta.Location = new System.Drawing.Point(25, 247);
            this.rdoPregunta.Name = "rdoPregunta";
            this.rdoPregunta.Size = new System.Drawing.Size(68, 17);
            this.rdoPregunta.TabIndex = 5;
            this.rdoPregunta.TabStop = true;
            this.rdoPregunta.Text = "Pregunta";
            this.rdoPregunta.UseVisualStyleBackColor = true;
            this.rdoPregunta.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoInfor
            // 
            this.rdoInfor.AutoSize = true;
            this.rdoInfor.Location = new System.Drawing.Point(25, 204);
            this.rdoInfor.Name = "rdoInfor";
            this.rdoInfor.Size = new System.Drawing.Size(80, 17);
            this.rdoInfor.TabIndex = 4;
            this.rdoInfor.TabStop = true;
            this.rdoInfor.Text = "Información";
            this.rdoInfor.UseVisualStyleBackColor = true;
            this.rdoInfor.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoMano
            // 
            this.rdoMano.AutoSize = true;
            this.rdoMano.Location = new System.Drawing.Point(25, 161);
            this.rdoMano.Name = "rdoMano";
            this.rdoMano.Size = new System.Drawing.Size(52, 17);
            this.rdoMano.TabIndex = 3;
            this.rdoMano.TabStop = true;
            this.rdoMano.Text = "Mano";
            this.rdoMano.UseVisualStyleBackColor = true;
            this.rdoMano.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoExclamacion
            // 
            this.rdoExclamacion.AutoSize = true;
            this.rdoExclamacion.Location = new System.Drawing.Point(25, 118);
            this.rdoExclamacion.Name = "rdoExclamacion";
            this.rdoExclamacion.Size = new System.Drawing.Size(85, 17);
            this.rdoExclamacion.TabIndex = 2;
            this.rdoExclamacion.TabStop = true;
            this.rdoExclamacion.Text = "Exclamación";
            this.rdoExclamacion.UseVisualStyleBackColor = true;
            this.rdoExclamacion.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoError
            // 
            this.rdoError.AutoSize = true;
            this.rdoError.Location = new System.Drawing.Point(25, 75);
            this.rdoError.Name = "rdoError";
            this.rdoError.Size = new System.Drawing.Size(47, 17);
            this.rdoError.TabIndex = 1;
            this.rdoError.TabStop = true;
            this.rdoError.Text = "Error";
            this.rdoError.UseVisualStyleBackColor = true;
            this.rdoError.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // rdoAsterisco
            // 
            this.rdoAsterisco.AutoSize = true;
            this.rdoAsterisco.Location = new System.Drawing.Point(25, 32);
            this.rdoAsterisco.Name = "rdoAsterisco";
            this.rdoAsterisco.Size = new System.Drawing.Size(68, 17);
            this.rdoAsterisco.TabIndex = 0;
            this.rdoAsterisco.TabStop = true;
            this.rdoAsterisco.Text = "Asterisco";
            this.rdoAsterisco.UseVisualStyleBackColor = true;
            this.rdoAsterisco.CheckedChanged += new System.EventHandler(this.TipoIcono_CheckedChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(42, 299);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(174, 29);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMostar
            // 
            this.lblMostar.AutoSize = true;
            this.lblMostar.Location = new System.Drawing.Point(42, 346);
            this.lblMostar.Name = "lblMostar";
            this.lblMostar.Size = new System.Drawing.Size(0, 13);
            this.lblMostar.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 415);
            this.Controls.Add(this.lblMostar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grpIcono);
            this.Controls.Add(this.grpTipoBoton);
            this.Name = "frmPrincipal";
            this.Text = "Demostración de los controles RadioButton";
            this.grpTipoBoton.ResumeLayout(false);
            this.grpTipoBoton.PerformLayout();
            this.grpIcono.ResumeLayout(false);
            this.grpIcono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoBoton;
        private System.Windows.Forms.RadioButton rdoAceptar;
        private System.Windows.Forms.GroupBox grpIcono;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMostar;
        private System.Windows.Forms.RadioButton rdoRC;
        private System.Windows.Forms.RadioButton rdoSN;
        private System.Windows.Forms.RadioButton rdoSNC;
        private System.Windows.Forms.RadioButton rdoARI;
        private System.Windows.Forms.RadioButton rdoCancelar;
        private System.Windows.Forms.RadioButton rdoAdvert;
        private System.Windows.Forms.RadioButton rdoAlto;
        private System.Windows.Forms.RadioButton rdoPregunta;
        private System.Windows.Forms.RadioButton rdoInfor;
        private System.Windows.Forms.RadioButton rdoMano;
        private System.Windows.Forms.RadioButton rdoExclamacion;
        private System.Windows.Forms.RadioButton rdoError;
        private System.Windows.Forms.RadioButton rdoAsterisco;
    }
}

