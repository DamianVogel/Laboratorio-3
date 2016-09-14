using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro
    {
        string _nombre;
        string _raza;
        int _edad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Raza
        {
            get
            {
                return _raza;
            }

            set
            {
                _raza = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }

        public override string ToString()
        {
            return this.Edad.ToString() + "," + this.Nombre + "," + this.Raza;
        }

        public static int OrdenarPorRaza(object perro1, object perro2)
        {
            if ((perro1 != null) && (perro2 != null))
            {
                Perro p1 = (Perro)perro1;
                Perro p2 = (Perro)perro2;
                return String.Compare(p1.Raza, p2.Raza);//
            }
            return 0;
        }
        
    }
}
