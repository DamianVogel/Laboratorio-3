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
    // el formulario demuestra el uso de las ventanas MDI padre e hijos
    public partial class DemoMDI : Form
    {
        public DemoMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void hijo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea un nuevo hijo1
            bool esta = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmHijo)
                {
                    frmHijo f = (frmHijo)frm;
                    if (f.Text == "Hijo 1")
                    {
                        esta = true;
                    }
                }


            }

            if (!esta)
            {
                frmHijo frmChild = new frmHijo("Hijo 1", Properties.Resources.C_);
                frmChild.MdiParent = this;
                frmChild.Show();
            }
            else
            {
                MessageBox.Show("Ya esta abierto");
            }

         
        }

        private void hijo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHijo frmChild = new frmHijo("Hijo 2", Properties.Resources.Java);
            frmChild.MdiParent = this;
            frmChild.Show();

            this.hijo2ToolStripMenuItem.Enabled = false;

            
        }

        private void hijo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHijo frmChild = new frmHijo("Hijo 3", Properties.Resources.Python);
            frmChild.MdiParent = this;
            frmChild.Show();

            this.hijo3ToolStripMenuItem.Enabled = false;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
