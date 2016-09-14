using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace ControlesDeUsuario
{
    public class TextBoxColor : TextBox
    {
        private Color _colorEnfocado;

        public Color ColorEnfocado
        {
            get { return _colorEnfocado; }
            set { _colorEnfocado = value; }
        }

        private Color _colorDesenfocado;

        public Color ColorDesenfocado
        {
            get { return _colorDesenfocado; }
            set { _colorDesenfocado = value; }
        }

        private bool _aplicarColorFoco;

        public bool AplicarColorFoco
        {
            get { return _aplicarColorFoco; }
            set { _aplicarColorFoco = value; }
        }
        

        protected override void OnMouseEnter(EventArgs e)
        {
            if(this._aplicarColorFoco)
            this.BackColor = this._colorEnfocado;            
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if(this._aplicarColorFoco)
            this.BackColor = this._colorDesenfocado;
        }
    }
}
