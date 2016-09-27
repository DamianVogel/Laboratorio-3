using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mascota
{
    class Mascota:Animal
    {
        protected string _nombre;
        protected eTipoDeMascota _tipoDeMascota;


        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
            
        }

        public string Nombre { get {return this._nombre; }  }
        public eTipoDeMascota TipoDeMascota { get { return this._tipoDeMascota; } }


        public int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        {
            if (mascotaUno._edad > mascotaDos._edad)
            {
                return 1;
            }

            if (mascotaUno._edad < mascotaDos._edad)
            {
                return -1;
            }

            return 0;
        }

        public int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {

            return String.Compare(mascotaUno._nombre, mascotaDos._nombre);
            
        }


        public int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {

            return String.Compare(mascotaUno._tipoDeMascota.ToString(), mascotaDos._tipoDeMascota.ToString());
            
            
        }

        public override string ToString()
        {
            return this._nombre + " " + this._edad.ToString() + " " + this._tipoDeMascota.ToString();
        }

    
    
    }
}
