using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTecla
{
    // Formulario para mostrar información de la tecla que se oprimió
    public partial class TeclasDemoForm : Form
    {
        public TeclasDemoForm()
        {
            InitializeComponent();
        }

        // Muestra el caracter que se oprimió
        private void TeclasDemoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.caracterLabel.Text = "Se oprimió la tecla: " + e.KeyChar;

        }

        // Muestra teclas modificadoras, código de tecla, datos de tecla y su valor
        private void TeclasDemoForm_KeyDown(object sender, KeyEventArgs e)
        {
            infoTeclaLabel.Text =
                "Alt: " + (e.Alt ? "Si" : "No") + '\n' +
                "Mayús: " + (e.Shift ? "Si" : "No") + '\n' +
                "Ctrl: " + (e.Control ? "Si" : "No") + '\n' +
                "Código tecla: " + e.KeyCode + '\n' +
                "Datos tecla: " + e.KeyData + '\n' +
                "Valor de tecla: " + e.KeyValue;

        }

        // Borra controles label cuando se suelta una tecla
        private void TeclasDemoForm_KeyUp(object sender, KeyEventArgs e)
        {
            this.caracterLabel.Text = "";
            this.infoTeclaLabel.Text = "";

        }





        
    }
}
