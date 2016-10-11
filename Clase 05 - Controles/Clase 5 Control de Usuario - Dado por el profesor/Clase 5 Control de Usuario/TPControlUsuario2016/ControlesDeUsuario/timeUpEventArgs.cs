using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeUsuario
{
    public class timeUpEventArgs
    {
        private DateTime _fechaEvento;

        public DateTime FechaEvento
        {
            get { return _fechaEvento; }
            
        }

        public timeUpEventArgs()
        {
            this._fechaEvento = DateTime.Now;
        }
        

    }
}
