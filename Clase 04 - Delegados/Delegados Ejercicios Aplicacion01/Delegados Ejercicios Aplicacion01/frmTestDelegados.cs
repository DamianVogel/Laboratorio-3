using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;

namespace Delegados_Ejercicios_Aplicacion01
{
    public partial class frmTestDelegados : Form
    {
          private string _ruta;
        
        public frmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            
        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {
           //button2.Click -= button2_Click;

          // button2.MouseDoubleClick += this.DobleClick;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
             FrmPrincipal changer = (FrmPrincipal)this.Owner;
            
            changer.miDelegado(this.textBox1.Text);
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string dir = this.openFileDialog1.FileName;

                this._ruta = Path.GetFullPath(dir);

                FrmPrincipal changer = (FrmPrincipal)this.Owner;
                changer.miDelegado2(this._ruta);
            }

        }

        //private void DobleClick(object sender, MouseEventArgs e)
        //{
            
            
        //    if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        string dir = this.openFileDialog1.FileName;

        //        this._ruta = Path.GetFullPath(dir);

        //        FrmPrincipal changer = (FrmPrincipal)this.Owner;
        //        changer.miDelegado2(this._ruta);
        //    }
        



        //}

      


    }
}
