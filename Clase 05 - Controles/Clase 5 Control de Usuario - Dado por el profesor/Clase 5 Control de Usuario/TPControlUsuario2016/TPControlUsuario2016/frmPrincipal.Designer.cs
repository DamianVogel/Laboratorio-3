namespace TPControlUsuario2016
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
            this.lblTxtSoloNumeros = new System.Windows.Forms.Label();
            this.lbltxtSoloNumerosFull = new System.Windows.Forms.Label();
            this.lblTxtCaracterOculto = new System.Windows.Forms.Label();
            this.lbltxtBoxColor = new System.Windows.Forms.Label();
            this.lblTxtFechaValida = new System.Windows.Forms.Label();
            this.usrAlarma1 = new ControlesDeUsuario.UsrAlarma();
            this.txtSoloNumeros1 = new ControlesDeUsuario.txtSoloNumeros();
            this.txtSoloNumerosFull1 = new ControlesDeUsuario.txtSoloNumerosFull();
            this.txtCaracterOculto1 = new ControlesDeUsuario.txtCaracterOculto();
            this.textBoxColor1 = new ControlesDeUsuario.TextBoxColor();
            this.txtFechaValida1 = new ControlesDeUsuario.txtFechaValida();
            this.controlLogin1 = new ControlesDeUsuario.ControlLogin();
            this.usrControlFechaEnLetras1 = new ControlesDeUsuario.UsrControlFechaEnLetras();
            this.SuspendLayout();
            // 
            // lblTxtSoloNumeros
            // 
            this.lblTxtSoloNumeros.AutoSize = true;
            this.lblTxtSoloNumeros.Location = new System.Drawing.Point(60, 43);
            this.lblTxtSoloNumeros.Name = "lblTxtSoloNumeros";
            this.lblTxtSoloNumeros.Size = new System.Drawing.Size(81, 13);
            this.lblTxtSoloNumeros.TabIndex = 2;
            this.lblTxtSoloNumeros.Text = "txtSoloNumeros";
            // 
            // lbltxtSoloNumerosFull
            // 
            this.lbltxtSoloNumerosFull.AutoSize = true;
            this.lbltxtSoloNumerosFull.Location = new System.Drawing.Point(60, 69);
            this.lbltxtSoloNumerosFull.Name = "lbltxtSoloNumerosFull";
            this.lbltxtSoloNumerosFull.Size = new System.Drawing.Size(97, 13);
            this.lbltxtSoloNumerosFull.TabIndex = 3;
            this.lbltxtSoloNumerosFull.Text = "txtSoloNumerosFull";
            // 
            // lblTxtCaracterOculto
            // 
            this.lblTxtCaracterOculto.AutoSize = true;
            this.lblTxtCaracterOculto.Location = new System.Drawing.Point(60, 95);
            this.lblTxtCaracterOculto.Name = "lblTxtCaracterOculto";
            this.lblTxtCaracterOculto.Size = new System.Drawing.Size(89, 13);
            this.lblTxtCaracterOculto.TabIndex = 5;
            this.lblTxtCaracterOculto.Text = "txtCaracterOculto";
            // 
            // lbltxtBoxColor
            // 
            this.lbltxtBoxColor.AutoSize = true;
            this.lbltxtBoxColor.Location = new System.Drawing.Point(60, 151);
            this.lbltxtBoxColor.Name = "lbltxtBoxColor";
            this.lbltxtBoxColor.Size = new System.Drawing.Size(66, 13);
            this.lbltxtBoxColor.TabIndex = 7;
            this.lbltxtBoxColor.Text = "textBoxColor";
            // 
            // lblTxtFechaValida
            // 
            this.lblTxtFechaValida.AutoSize = true;
            this.lblTxtFechaValida.Location = new System.Drawing.Point(60, 177);
            this.lblTxtFechaValida.Name = "lblTxtFechaValida";
            this.lblTxtFechaValida.Size = new System.Drawing.Size(77, 13);
            this.lblTxtFechaValida.TabIndex = 9;
            this.lblTxtFechaValida.Text = "txtFechaValida";
            // 
            // usrAlarma1
            // 
            this.usrAlarma1.Activada = false;
            this.usrAlarma1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrAlarma1.FechaHoraAlarma = new System.DateTime(((long)(0)));
            this.usrAlarma1.Location = new System.Drawing.Point(26, 241);
            this.usrAlarma1.Name = "usrAlarma1";
            this.usrAlarma1.Size = new System.Drawing.Size(291, 86);
            this.usrAlarma1.TabIndex = 11;
            // 
            // txtSoloNumeros1
            // 
            this.txtSoloNumeros1.Location = new System.Drawing.Point(170, 40);
            this.txtSoloNumeros1.Name = "txtSoloNumeros1";
            this.txtSoloNumeros1.Size = new System.Drawing.Size(100, 20);
            this.txtSoloNumeros1.TabIndex = 0;
            // 
            // txtSoloNumerosFull1
            // 
            this.txtSoloNumerosFull1.Location = new System.Drawing.Point(170, 66);
            this.txtSoloNumerosFull1.Name = "txtSoloNumerosFull1";
            this.txtSoloNumerosFull1.Size = new System.Drawing.Size(100, 20);
            this.txtSoloNumerosFull1.TabIndex = 1;
            this.txtSoloNumerosFull1.TipoDeDato = ControlesDeUsuario.eTipoDato.Hexadecimal;
            // 
            // txtCaracterOculto1
            // 
            this.txtCaracterOculto1.CaracterOculto = 'a';
            this.txtCaracterOculto1.Location = new System.Drawing.Point(170, 92);
            this.txtCaracterOculto1.Name = "txtCaracterOculto1";
            this.txtCaracterOculto1.Size = new System.Drawing.Size(100, 20);
            this.txtCaracterOculto1.TabIndex = 4;
            // 
            // textBoxColor1
            // 
            this.textBoxColor1.AplicarColorFoco = true;
            this.textBoxColor1.ColorDesenfocado = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxColor1.ColorEnfocado = System.Drawing.Color.Lime;
            this.textBoxColor1.Location = new System.Drawing.Point(170, 148);
            this.textBoxColor1.Name = "textBoxColor1";
            this.textBoxColor1.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor1.TabIndex = 6;
            // 
            // txtFechaValida1
            // 
            this.txtFechaValida1.FormatoFecha = ControlesDeUsuario.eFormato.FormatoIngles;
            this.txtFechaValida1.Location = new System.Drawing.Point(170, 174);
            this.txtFechaValida1.Name = "txtFechaValida1";
            this.txtFechaValida1.Size = new System.Drawing.Size(100, 20);
            this.txtFechaValida1.TabIndex = 8;
            // 
            // controlLogin1
            // 
            this.controlLogin1.Location = new System.Drawing.Point(93, 200);
            this.controlLogin1.Name = "controlLogin1";
            this.controlLogin1.Size = new System.Drawing.Size(216, 25);
            this.controlLogin1.TabIndex = 10;
            this.controlLogin1.Load += new System.EventHandler(this.controlLogin1_Load);
            this.controlLogin1.Enter += new System.EventHandler(this.controlLogin1_Enter);
            // 
            // usrControlFechaEnLetras1
            // 
            this.usrControlFechaEnLetras1.Location = new System.Drawing.Point(344, 76);
            this.usrControlFechaEnLetras1.Name = "usrControlFechaEnLetras1";
            this.usrControlFechaEnLetras1.Size = new System.Drawing.Size(296, 251);
            this.usrControlFechaEnLetras1.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 434);
            this.Controls.Add(this.usrControlFechaEnLetras1);
            this.Controls.Add(this.usrAlarma1);
            this.Controls.Add(this.lblTxtSoloNumeros);
            this.Controls.Add(this.txtSoloNumeros1);
            this.Controls.Add(this.lbltxtSoloNumerosFull);
            this.Controls.Add(this.txtSoloNumerosFull1);
            this.Controls.Add(this.lblTxtCaracterOculto);
            this.Controls.Add(this.txtCaracterOculto1);
            this.Controls.Add(this.lbltxtBoxColor);
            this.Controls.Add(this.textBoxColor1);
            this.Controls.Add(this.lblTxtFechaValida);
            this.Controls.Add(this.txtFechaValida1);
            this.Controls.Add(this.controlLogin1);
            this.Name = "frmPrincipal";
            this.Text = "Controles de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesDeUsuario.txtSoloNumeros txtSoloNumeros1;
        private ControlesDeUsuario.txtSoloNumerosFull txtSoloNumerosFull1;
        private System.Windows.Forms.Label lblTxtSoloNumeros;
        private System.Windows.Forms.Label lbltxtSoloNumerosFull;
        private ControlesDeUsuario.txtCaracterOculto txtCaracterOculto1;
        private System.Windows.Forms.Label lblTxtCaracterOculto;
        private ControlesDeUsuario.TextBoxColor textBoxColor1;
        private System.Windows.Forms.Label lbltxtBoxColor;
        private ControlesDeUsuario.txtFechaValida txtFechaValida1;
        private System.Windows.Forms.Label lblTxtFechaValida;
        private ControlesDeUsuario.ControlLogin controlLogin1;
        private ControlesDeUsuario.UsrAlarma usrAlarma1;
        private ControlesDeUsuario.UsrControlFechaEnLetras usrControlFechaEnLetras1;

    }
}

