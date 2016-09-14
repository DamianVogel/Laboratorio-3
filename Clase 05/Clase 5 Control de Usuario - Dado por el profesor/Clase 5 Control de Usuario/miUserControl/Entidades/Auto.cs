using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        string _marca;
        int _cantPuertas;
        string _modelo;

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public int CantPuertas
        {
            get
            {
                return _cantPuertas;
            }

            set
            {
                _cantPuertas = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public override string ToString()
        {
            return this.CantPuertas.ToString() + "," + this.Marca + "," + this.Modelo;
        }

        public static int OrdenarPorMarca(object auto1, object auto2)
        {
            if ((auto1 != null)&& (auto2 != null)){
                Auto a1 = (Auto)auto1;
                Auto a2 = (Auto)auto2;
                return String.Compare(a1.Marca, a2.Marca);//
            }
            return 0;
        }
    }
}
