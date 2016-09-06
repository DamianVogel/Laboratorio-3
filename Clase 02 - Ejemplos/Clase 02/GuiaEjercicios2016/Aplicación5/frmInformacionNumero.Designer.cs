namespace Aplicación5
{
    partial class frmInformacionNumero
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
            this.pnlNumero = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.lblCantidadCifras = new System.Windows.Forms.Label();
            this.txtCantidadCifras = new System.Windows.Forms.TextBox();
            this.lblSumaImpares = new System.Windows.Forms.Label();
            this.txtSumaImpares = new System.Windows.Forms.TextBox();
            this.lblSumaPares = new System.Windows.Forms.Label();
            this.txtSumaPares = new System.Windows.Forms.TextBox();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.txtSumaTotal = new System.Windows.Forms.TextBox();
            this.lblCifraMayor = new System.Windows.Forms.Label();
            this.txtCifraMayor = new System.Windows.Forms.TextBox();
            this.lblCifraMenor = new System.Windows.Forms.Label();
            this.txtCifraMenor = new System.Windows.Forms.TextBox();
            this.grbDivisores = new System.Windows.Forms.GroupBox();
            this.lsbDivisores = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlNumero.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            this.grbDivisores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNumero
            // 
            this.pnlNumero.Controls.Add(this.lblNumero);
            this.pnlNumero.Controls.Add(this.txtNumero);
            this.pnlNumero.Location = new System.Drawing.Point(12, 12);
            this.pnlNumero.Name = "pnlNumero";
            this.pnlNumero.Size = new System.Drawing.Size(295, 100);
            this.pnlNumero.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(131, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese un número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(149, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.Controls.Add(this.lblCantidadCifras);
            this.PanelMostrar.Controls.Add(this.txtCantidadCifras);
            this.PanelMostrar.Controls.Add(this.lblSumaImpares);
            this.PanelMostrar.Controls.Add(this.txtSumaImpares);
            this.PanelMostrar.Controls.Add(this.lblSumaPares);
            this.PanelMostrar.Controls.Add(this.txtSumaPares);
            this.PanelMostrar.Controls.Add(this.lblSumaTotal);
            this.PanelMostrar.Controls.Add(this.txtSumaTotal);
            this.PanelMostrar.Controls.Add(this.lblCifraMayor);
            this.PanelMostrar.Controls.Add(this.txtCifraMayor);
            this.PanelMostrar.Controls.Add(this.lblCifraMenor);
            this.PanelMostrar.Controls.Add(this.txtCifraMenor);
            this.PanelMostrar.Location = new System.Drawing.Point(12, 141);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(295, 281);
            this.PanelMostrar.TabIndex = 1;
            // 
            // lblCantidadCifras
            // 
            this.lblCantidadCifras.AutoSize = true;
            this.lblCantidadCifras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCifras.Location = new System.Drawing.Point(21, 31);
            this.lblCantidadCifras.Name = "lblCantidadCifras";
            this.lblCantidadCifras.Size = new System.Drawing.Size(128, 17);
            this.lblCantidadCifras.TabIndex = 2;
            this.lblCantidadCifras.Text = "Cantidad de Cifras:";
            // 
            // txtCantidadCifras
            // 
            this.txtCantidadCifras.Location = new System.Drawing.Point(194, 30);
            this.txtCantidadCifras.Name = "txtCantidadCifras";
            this.txtCantidadCifras.Size = new System.Drawing.Size(64, 20);
            this.txtCantidadCifras.TabIndex = 3;
            // 
            // lblSumaImpares
            // 
            this.lblSumaImpares.AutoSize = true;
            this.lblSumaImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaImpares.Location = new System.Drawing.Point(21, 71);
            this.lblSumaImpares.Name = "lblSumaImpares";
            this.lblSumaImpares.Size = new System.Drawing.Size(160, 17);
            this.lblSumaImpares.TabIndex = 4;
            this.lblSumaImpares.Text = "Suma de cifras impares:";
            // 
            // txtSumaImpares
            // 
            this.txtSumaImpares.Location = new System.Drawing.Point(194, 70);
            this.txtSumaImpares.Name = "txtSumaImpares";
            this.txtSumaImpares.Size = new System.Drawing.Size(64, 20);
            this.txtSumaImpares.TabIndex = 5;
            // 
            // lblSumaPares
            // 
            this.lblSumaPares.AutoSize = true;
            this.lblSumaPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaPares.Location = new System.Drawing.Point(21, 111);
            this.lblSumaPares.Name = "lblSumaPares";
            this.lblSumaPares.Size = new System.Drawing.Size(146, 17);
            this.lblSumaPares.TabIndex = 6;
            this.lblSumaPares.Text = "Suma de cifras pares:";
            // 
            // txtSumaPares
            // 
            this.txtSumaPares.Location = new System.Drawing.Point(194, 110);
            this.txtSumaPares.Name = "txtSumaPares";
            this.txtSumaPares.Size = new System.Drawing.Size(64, 20);
            this.txtSumaPares.TabIndex = 7;
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.AutoSize = true;
            this.lblSumaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaTotal.Location = new System.Drawing.Point(21, 151);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(137, 17);
            this.lblSumaTotal.TabIndex = 8;
            this.lblSumaTotal.Text = "Suma total de cifras:";
            // 
            // txtSumaTotal
            // 
            this.txtSumaTotal.Location = new System.Drawing.Point(194, 150);
            this.txtSumaTotal.Name = "txtSumaTotal";
            this.txtSumaTotal.Size = new System.Drawing.Size(64, 20);
            this.txtSumaTotal.TabIndex = 9;
            // 
            // lblCifraMayor
            // 
            this.lblCifraMayor.AutoSize = true;
            this.lblCifraMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifraMayor.Location = new System.Drawing.Point(21, 191);
            this.lblCifraMayor.Name = "lblCifraMayor";
            this.lblCifraMayor.Size = new System.Drawing.Size(84, 17);
            this.lblCifraMayor.TabIndex = 10;
            this.lblCifraMayor.Text = "Cifra mayor:";
            // 
            // txtCifraMayor
            // 
            this.txtCifraMayor.Location = new System.Drawing.Point(194, 190);
            this.txtCifraMayor.Name = "txtCifraMayor";
            this.txtCifraMayor.Size = new System.Drawing.Size(64, 20);
            this.txtCifraMayor.TabIndex = 11;
            // 
            // lblCifraMenor
            // 
            this.lblCifraMenor.AutoSize = true;
            this.lblCifraMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifraMenor.Location = new System.Drawing.Point(21, 231);
            this.lblCifraMenor.Name = "lblCifraMenor";
            this.lblCifraMenor.Size = new System.Drawing.Size(85, 17);
            this.lblCifraMenor.TabIndex = 12;
            this.lblCifraMenor.Text = "Cifra menor:";
            // 
            // txtCifraMenor
            // 
            this.txtCifraMenor.Location = new System.Drawing.Point(194, 230);
            this.txtCifraMenor.Name = "txtCifraMenor";
            this.txtCifraMenor.Size = new System.Drawing.Size(64, 20);
            this.txtCifraMenor.TabIndex = 13;
            // 
            // grbDivisores
            // 
            this.grbDivisores.Controls.Add(this.lsbDivisores);
            this.grbDivisores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDivisores.Location = new System.Drawing.Point(330, 141);
            this.grbDivisores.Name = "grbDivisores";
            this.grbDivisores.Size = new System.Drawing.Size(295, 281);
            this.grbDivisores.TabIndex = 2;
            this.grbDivisores.TabStop = false;
            this.grbDivisores.Text = "Divisores";
            // 
            // lsbDivisores
            // 
            this.lsbDivisores.FormattingEnabled = true;
            this.lsbDivisores.ItemHeight = 18;
            this.lsbDivisores.Location = new System.Drawing.Point(13, 21);
            this.lsbDivisores.Name = "lsbDivisores";
            this.lsbDivisores.Size = new System.Drawing.Size(269, 238);
            this.lsbDivisores.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(330, 36);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 55);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(485, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 55);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInformacionNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 434);
            this.Controls.Add(this.pnlNumero);
            this.Controls.Add(this.PanelMostrar);
            this.Controls.Add(this.grbDivisores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmInformacionNumero";
            this.Text = "Información del Número";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInformacionNumero_FormClosing);
            this.pnlNumero.ResumeLayout(false);
            this.pnlNumero.PerformLayout();
            this.PanelMostrar.ResumeLayout(false);
            this.PanelMostrar.PerformLayout();
            this.grbDivisores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.Label lblCantidadCifras;
        private System.Windows.Forms.TextBox txtCantidadCifras;
        private System.Windows.Forms.Label lblSumaImpares;
        private System.Windows.Forms.TextBox txtSumaImpares;
        private System.Windows.Forms.Label lblSumaPares;
        private System.Windows.Forms.TextBox txtSumaPares;
        private System.Windows.Forms.Label lblSumaTotal;
        private System.Windows.Forms.TextBox txtSumaTotal;
        private System.Windows.Forms.Label lblCifraMayor;
        private System.Windows.Forms.TextBox txtCifraMayor;
        private System.Windows.Forms.Label lblCifraMenor;
        private System.Windows.Forms.TextBox txtCifraMenor;
        private System.Windows.Forms.GroupBox grbDivisores;
        private System.Windows.Forms.ListBox lsbDivisores;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

