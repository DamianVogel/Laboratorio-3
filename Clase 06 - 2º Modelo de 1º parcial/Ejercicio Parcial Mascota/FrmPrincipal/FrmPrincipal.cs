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
        
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            Comparison<Mascota> criterio;
            if (this.tscmbOrdenamiento.SelectedItem == (object)eTipoDeOrdenamiento.PorEdad)
            {
                criterio = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                this._listaMascota.Sort(criterio);
            }

            if (this.tscmbOrdenamiento.SelectedItem == (object)eTipoDeOrdenamiento.PorEdad)
            {
                criterio = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                this._listaMascota.Sort(criterio);
            }
        
        
        }
    }
}
