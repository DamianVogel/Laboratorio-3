using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escondite
    {
        private int _codEscondite;
        private String _lugar;

        public Escondite(int codEscondite, string lugar)
        {
            this._codEscondite = codEscondite;
            this._lugar = lugar;
        
        }

        public int CodigoEscondite { get { return this._codEscondite; } }
        public String Lugar { get { return this._lugar; } }

    
    }
}
