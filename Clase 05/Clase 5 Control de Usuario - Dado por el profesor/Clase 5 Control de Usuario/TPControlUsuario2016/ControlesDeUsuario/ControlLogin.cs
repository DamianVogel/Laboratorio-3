using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    // delegado especializado en guardar metodos del tipo del manejador del evento AvisarCapsLock
    public delegate void delegadoTecla(object sender, capsLockEventArgs e);

    public partial class ControlLogin : UserControl
    {
        // declaro una variable evento del tipo del delegado
        public event delegadoTecla AvisarCapsLock;
        // declaro una variable de tipo ErrorProvider
        private ErrorProvider ProvError;

        public ControlLogin()
        {
            InitializeComponent();
        }     

        private void ControlLogin_Load(object sender, EventArgs e)
        {
            // conecto el evento con su manejador dinamicamente
            this.AvisarCapsLock += this.capslockActivada;
            // instancio el ErrorProvider
            ProvError = new ErrorProvider();                  
        }

        private void capslockActivada(object sender, capsLockEventArgs e)
        {
            // en el manejador del evento AvisarCapsLock, si me informa que esta presionada seteo el error del error provider, en caso contrario limpio el error provider
            if (e.CapsLockPresionada)
            {               
                ProvError.SetError(this.textBox1, "CapsLock Activada");                
            }
            else
            {
                // antes de limpiar el error provider me aseguro que haya estado instanciado en algun momento
                if(ProvError != null)
                ProvError.Clear();
            }

        }

     
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // cada vez que se presiona una tecla lanzo el evento AvisarCapsLock informando si esta activa o no esa tecla
                 if (Control.IsKeyLocked(Keys.CapsLock))
            {
                AvisarCapsLock(this, new capsLockEventArgs(true));
            }
            else
            {
                AvisarCapsLock(this, new capsLockEventArgs(false));

            }
            base.OnKeyPress(e);     
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {   
            // cuando el textbox toma foco lanzo el evento AvisarCapsLock informando si esta activa o no esa tecla
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                AvisarCapsLock(this, new capsLockEventArgs(true));
            }
            else
            {
                AvisarCapsLock(this, new capsLockEventArgs(false));

            }
        }    
    }
}
