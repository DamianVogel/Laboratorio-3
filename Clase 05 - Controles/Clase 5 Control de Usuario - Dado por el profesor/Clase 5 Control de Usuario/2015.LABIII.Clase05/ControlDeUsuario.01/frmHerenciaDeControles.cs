﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeUsuario._01
{
    public partial class frmHerenciaDeControles : Form
    {
        //DECLARO UN OBJETO DE TIPO TEXTBOXCOLORES
        private MisControles.TextBoxColores _txtTexboxColores;

        public frmHerenciaDeControles()
        {
            InitializeComponent();

          //  this.Load += new EventHandler(CrearControl);
           this.btnCrear.Click += this.CrearControl;
           // this.btnCrear.Click += new System.EventHandler(this.CrearControl);
           this.btnCrear.Click += new EventHandler(this.CerrarFormulario); 
        }

        private void CrearControl(Object sender, EventArgs e)
        {
 
            //CREO EL OBJETODE TIPO 'TEXTBOXCOLORES'
            this._txtTexboxColores = new MisControles.TextBoxColores(Color.Gold);
            this._txtTexboxColores.Location = new Point(78, 100);
            this._txtTexboxColores.Name = "txtColores";
            this._txtTexboxColores.Size = new Size(100, 40);
            this._txtTexboxColores.TabIndex = 1;

            //LO AGREGO A LA COLECCION DE CONTROLES DEL FORMULARIO
            this.Controls.Add(this._txtTexboxColores);

            //QUITO EL MANEJADOR DE EVENTOS
            this.btnCrear.Click -= this.CrearControl;

        }

        private void CerrarFormulario(object sender, EventArgs e)
        {
            if ((Button)sender is Button)
            {
                MessageBox.Show("Es un boton");
            }
        
        }
    
    
    
    
    }
}
