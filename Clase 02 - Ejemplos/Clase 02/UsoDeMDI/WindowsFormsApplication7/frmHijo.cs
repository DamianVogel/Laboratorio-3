using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class frmHijo : Form
    {
        public frmHijo()
        {
            InitializeComponent();

        }

        public frmHijo(String titulo, Image pathImagen)
            : this()
        {
            this.Text = titulo;
            this.pcbImagen.Image = pathImagen;
        }


        private void frmHijo_Paint(object sender, PaintEventArgs e)
        {
            this.pcbImagen.Width = this.Width - 40;
            this.pcbImagen.Height = this.Height - 62;
        }


    }
}
