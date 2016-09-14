using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeUsuario
{
    public class capsLockEventArgs
    {
        private bool _estaPresionada;

        public bool CapsLockPresionada
        {
            get { return _estaPresionada; }
            
        }

        public capsLockEventArgs( bool presionada)
        {
            this._estaPresionada = presionada;
        }
        
    }
}
