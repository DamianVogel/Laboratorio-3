using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRadioButton
{

    // El formulario contiene varios controles RadioButton, el usuario selecciona
    // uno de cada grupo para crear un cuadro de dialogo MessageBox personalizado.

    public partial class frmPrincipal : Form
    {

        // Crea variables que almacenan la seleccion de opciones del usuario

        private MessageBoxIcon tipoIcono;
        private MessageBoxButtons tipoBoton;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void rdoAceptar_CheckedChanged(object sender, EventArgs e)
        {

            //if (sender == rdoAceptar)
            //{
            //    this.tipoBoton = MessageBoxButtons.OK;
            //}
            //else
            //{
            //    if (sender == rdoCancelar)
            //    {
            //        this.tipoBoton = MessageBoxButtons.OKCancel;
            //    }
            //    else
            //    {
            //        if (sender == rdoARI)
            //        {


            //        }


            //    }
            //}

            switch (((RadioButton)sender).Name)
            {
                case "rdoAceptar": this.tipoBoton = MessageBoxButtons.OK;
                    break;
                case "rdoCancelar": this.tipoBoton = MessageBoxButtons.OKCancel;
                    break;
                case "rdoARI": this.tipoBoton = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case "rdoSNC": this.tipoBoton = MessageBoxButtons.YesNoCancel;
                    break;
                case "rdoSN": this.tipoBoton = MessageBoxButtons.YesNo;
                    break;
                case "rdoRC": this.tipoBoton = MessageBoxButtons.RetryCancel;
                    break;
            }
            
          
        }

        private void TipoIcono_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "rdoAsterisco": this.tipoIcono = MessageBoxIcon.Asterisk;
                    break;
                case "rdoError": this.tipoIcono = MessageBoxIcon.Error;
                    break;
                case "rdoExclamacion": this.tipoIcono = MessageBoxIcon.Exclamation;
                    break;
                case "rdoMano": this.tipoIcono = MessageBoxIcon.Hand;
                    break;
                case "rdoInfor": this.tipoIcono = MessageBoxIcon.Information;
                    break;
                case "rdoPregunta": this.tipoIcono = MessageBoxIcon.Question;
                    break;
                case "rdoAlto": this.tipoIcono = MessageBoxIcon.Stop;                  
                    break;
                case "rdoAdvert": this.tipoIcono = MessageBoxIcon.Warning;                   
                    break;
                    
            }         
            
        }

        // Muestra MessageBox y Button que oprimió el usuario.

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(tipoBoton.ToString(), tipoIcono.ToString(), tipoBoton, tipoIcono, 0, 0);

            // Comprueba que boton se oprimio en el MessageBox
            switch (resultado)
            {
                case DialogResult.OK :
                    lblMostar.Text = "Se oprimió Aceptar";
                    break;
                case DialogResult.Cancel :
                    lblMostar.Text = "Se oprimió Cancelar";
                    break;
                case DialogResult.Abort :
                    lblMostar.Text = "Se oprimió Abortar";
                    break;
                case DialogResult.Retry:
                    lblMostar.Text = "Se oprimió Reintentar";
                    break;
                case DialogResult.Ignore:
                    lblMostar.Text = "Se oprimió Ignorar";
                    break;
                case DialogResult.Yes:
                    lblMostar.Text = "Se oprimió Yes";
                    break;
                case DialogResult.No:
                    lblMostar.Text = "Se oprimió No";
                    break;
                                       
            }                                       

        }
     
    }
}
