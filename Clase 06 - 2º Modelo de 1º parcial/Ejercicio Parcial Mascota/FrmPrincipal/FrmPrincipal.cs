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

        public delegate void Delegado(List<Mascota> lista);

        public Delegado miDelegado;
        
        
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
        //Ordenamiento
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

            if (frmMascota.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this._listaMascota.Add(frmMascota.UnaMascota);
                this.listBox1.Items.Clear();

                foreach (Mascota masc in this._listaMascota)
                {
                    this.listBox1.Items.Add(masc);
                
                }

                //FrmPrincipal dueño = (FrmPrincipal)this.Owner;
                //dueño.miDelegado(this._listaMascota);

                miDelegado(this._listaMascota);
            }
          
        
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
           // this.modificarToolStripMenuItem.Click -= this.ManejadorCentral;
            //this.bajaToolStripMenuItem.Click -= this.ManejadorCentral;

            ToolStripMenuItem boton = (ToolStripMenuItem)sender;



            if (boton.Text == this.modificarToolStripMenuItem.Text)
            {
                
                FrmMascota frmMod = new FrmMascota();


                Mascota mascotaBaja = (Mascota)this.listBox1.SelectedItem;

                frmMod.txtEdad.Text = mascotaBaja.Edad.ToString();
                frmMod.txtName.Text = mascotaBaja.Nombre;
                frmMod.cmbMascota.SelectedIndex = (int)mascotaBaja.TipoDeMascota;

                if (frmMod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.modificarToolStripMenuItem.Click -= this.ManejadorCentral;
                    int indice = this.listBox1.SelectedIndex;

                    this._listaMascota.RemoveAt(indice);

                    this._listaMascota.Add(frmMod.UnaMascota);
                    
                    this.listBox1.Items.Clear();

                    foreach (Mascota masc in this._listaMascota)
                    {
                        this.listBox1.Items.Add(masc);

                    }

                    
                    miDelegado(this._listaMascota);

                }
                

            
            }

            if (boton.Text == this.bajaToolStripMenuItem.Text)
            {


                FrmMascota frmBaja = new FrmMascota();


                Mascota mascotaBaja = (Mascota)this.listBox1.SelectedItem;

                frmBaja.txtEdad.Text = mascotaBaja.Edad.ToString();
                frmBaja.txtName.Text = mascotaBaja.Nombre;
                frmBaja.cmbMascota.SelectedIndex = (int)mascotaBaja.TipoDeMascota;

                if (frmBaja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.bajaToolStripMenuItem.Click -= this.ManejadorCentral;

                    int indice = this.listBox1.SelectedIndex;
                    
                    this._listaMascota.RemoveAt(indice);

                    this.listBox1.Items.Clear();

                    foreach (Mascota masc in this._listaMascota)
                    {
                        this.listBox1.Items.Add(masc);

                    }

                    //FrmPrincipal dueño = (FrmPrincipal)this.Owner;
                    miDelegado(this._listaMascota);
                
                }

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

        private void CerrarFormulario(object sender, FormClosingEventArgs e)
        {

           // Form miMB = new Form();

            //miMB.BackColor = Color.DarkGray;
            //miMB.Text = "Salir?";
            
            
            DialogResult respuesta = MessageBox.Show("Desea cerrar la aplicacion?", "Salir?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (respuesta == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
             e.Cancel = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosing+=this.CerrarFormulario;
            
        
        }

        private void mostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();
            frmMostrar.Show(this);

        }
    


    
    
    }
}
