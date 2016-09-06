using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02Recursos
{
    public partial class frmRecursos : Form
    {
        public frmRecursos()
        {
            InitializeComponent();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bamboo;
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Prefijos);
        }

        private void btnSonidos_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

            sp.Stream = Properties.Resources.winAquariumDefault;
            sp.Load();
            sp.Play();
        }

        private void btnIcono_Click(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Help;
        }
    }
}
