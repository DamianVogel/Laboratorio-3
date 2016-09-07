using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    //Declaro un Delegado
    public delegate void DelegLimSueldoPro(object sender, EmpleadoEventArgs e);

    public class EmpleadoMejorado
    {
        //Declaro un Evento
        public event DelegLimSueldoPro LimiteSueldo;
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
            get { return this._sueldo; }
            set
            {
                //SI EL VALOR SUPERA AL PERMITIDO...
                if (value > 1000)
                {
                    //CREO UN OBJETO EMPLEADOEVENTARGS
                    //Y LE PASO A SUS PROPIEDADES
                    //INFORMACION SOBRE EL EVENTO.
                    //EN ESTE CASO SOLO PASO EL VALOR 
                    //INCORRECTO QUE SE INTENTO ASIGNAR
                    EmpleadoEventArgs miEventArgs = new EmpleadoEventArgs();

                    miEventArgs.SueldoIntentadoAsignar = value;

                    //DESPUES LANZO EL EVENTO
                    //Y LE PASO COMO PARAMETRO EL PROPIO
                    //OBJETO CON LA INFORMACION DEL EVENTO
                    LimiteSueldo(this, miEventArgs);
                }
                else
                {
                    this._sueldo = value;
                }

            }
        }
        #endregion

    }
}
