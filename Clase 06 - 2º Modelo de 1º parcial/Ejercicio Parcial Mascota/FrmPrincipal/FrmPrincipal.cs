using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        private List<Mascota> _listaMascota;
        
        public FrmPrincipal()
        {
            InitializeComponent();
            this._listaMascota = new List<Mascota>();
            this.tscmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (eTipoDeOrdenamiento tipo in Enum.GetValues(typeof(eTipoDeOrdenamiento)))
            {
                this.tscmbOrdenamiento.Items.Add(tipo);
            }

            this.tscmbOrdenamiento.Click -= this.toolStripComboBox1_Click;
            this.tscmbOrdenamiento.SelectedIndexChanged += this.toolStripComboBox1_Click;
            //this.listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
        
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            Comparison<Mascota> criterio;
            if (this.tscmbOrdenamiento.SelectedIndex == 0)
            {
                criterio = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                this._listaMascota.Sort(criterio);

                this.listBox1.Items.Clear();

                foreach (Mascota masc in this._listaMascota)
                {
                    this.listBox1.Items.Add(masc);

                }
            
            }

            if (this.tscmbOrdenamiento.SelectedIndex == 1)
            {
                criterio = new Comparison<Mascota>(Mascota.OrdenarPorNombre);
                this._listaMascota.Sort(criterio);

                this.listBox1.Items.Clear();

                foreach (Mascota masc in this._listaMascota)
                {
                    this.listBox1.Items.Add(masc);

                }
            
            
            
            }

            if (this.tscmbOrdenamiento.SelectedIndex == 2)
            {
                criterio = new Comparison<Mascota>(Mascota.OrdenarPorTipo);
                this._listaMascota.Sort(criterio);

                this.listBox1.Items.Clear();

                foreach (Mascota masc in this._listaMascota)
                {
                    this.listBox1.Items.Add(masc);

                }
            
            
            
            }
        
           

        
        }

        



        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascota frmMascota = new FrmMascota();
           // frmMascota.Show(this);

            if (frmMascota.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this._listaMascota.Add(frmMascota.UnaMascota);
                this.listBox1.Items.Clear();

                foreach (Mascota masc in this._listaMascota)
                {
                    this.listBox1.Items.Add(masc);
                
                }

               
            }
          
        
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            this.modificarToolStripMenuItem.Click -= this.ManejadorCentral;
            this.bajaToolStripMenuItem.Click -= this.ManejadorCentral;
            
            
            //Button boton = (Button)sender;

            ToolStripMenuItem boton = (ToolStripMenuItem)sender;



            if (boton.Text == this.modificarToolStripMenuItem.Text)
            {
               
            
            }

            if (boton.Text == this.bajaToolStripMenuItem.Text)
            {

                FrmMascota frmBaja = new FrmMascota();


                Mascota mascotaBaja = (Mascota)this.listBox1.SelectedItem;

                frmBaja.txtEdad.Text = mascotaBaja.Edad.ToString();
                frmBaja.txtName.Text = mascotaBaja.Nombre;
                frmBaja.cmbMascota.SelectedIndex = (int)mascotaBaja.TipoDeMascota;

                frmBaja.Show();

            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this._listaMascota.Count > 0)
            {
                this.modificarToolStripMenuItem.Click += this.ManejadorCentral;
                this.bajaToolStripMenuItem.Click += this.ManejadorCentral;
            }
        
        
        }
    
    
    
    
    
    }
}
