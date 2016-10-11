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
    public partial class FrmMascota : FrmAnimal
    {
        Mascota unaMascota;
        public Mascota UnaMascota { get { return this.unaMascota; } }
  
        
        public FrmMascota()
        {
            InitializeComponent();
        
            foreach(eTipoDeMascota tipo in Enum.GetValues(typeof(eTipoDeMascota)))
            {
                this.cmbMascota.Items.Add(tipo);
            }

            this.cmbMascota.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMascota.SelectedItem = eTipoDeMascota.exotica;        
        }

        

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            
            this.unaMascota = new Mascota(this.txtName.Text,(eTipoDeMascota)this.cmbMascota.SelectedItem,int.Parse(this.txtEdad.Text));
            //base.btnAceptar_Click(sender, e);
            this.DialogResult = DialogResult.OK;
        }
    
    
    
    
    
    }
}
