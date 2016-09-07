using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void LimiteSueldoDel(Empleado e, Double sueldo);

    public enum TipoManejador
    {
        SobreAsignacionSueldo = 1,
        SalarioIncorrecto = 2,
        Ambos = 3
    }

    public class Empleado
    {

        public event LimiteSueldoDel LimiteSueldo;

        #region Atributos

        private String _nombre;
        private Double _sueldo;

        #endregion

        #region Propiedades

        public String Nombre
         {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Double Sueldo 
        { 
            get{ return this._sueldo;}
            set
            {
                //Si el valor supera al permitido
                if (value > 1000)
                {

                    //Lanzo una Excepción
                    //throw new Exception("Gana mucho");
                    LimiteSueldo(this, value);
                }
                else
                {
                    this._sueldo = value;
                }
            }


        #endregion 

                        

        }

        
    }
}
