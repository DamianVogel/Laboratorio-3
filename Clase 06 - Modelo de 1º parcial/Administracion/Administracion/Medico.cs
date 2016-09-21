using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion
{
    public class Medico
    {
        protected eEspecialidades _especialidad;
        protected DateTime _horarioEntrada;
        protected string _legajo;
        protected string _nombre;

        public Medico(string nombre, string legajo, eEspecialidades especialidad)
        {
            this._especialidad = especialidad;
            this._legajo = legajo;
            this._nombre = nombre;
            this._horarioEntrada = DateTime.Now;
        
        }

        public eEspecialidades Especialidad { get { return this._especialidad; } set { this._especialidad = value; } }
        public DateTime Ingreso { get { return this._horarioEntrada; } set { this._horarioEntrada = value; } }
        public string Legajo { get { return this._legajo; } set { this._legajo = value; } }
        public string Nombre { get{return this._nombre;} set{this._nombre=value; }}


        public int OrdenarPorHorarioEntrada(Medico m1, Medico m2)
        {
            if (m1._horarioEntrada > m2._horarioEntrada)
            {
                return 1;
            }

            if (m1._horarioEntrada < m2._horarioEntrada)
            {
                return -1;
            }

            return 0;
        
        }

        public int OrdenarPorLegajo(Medico m1, Medico m2)
        {
            
            if (int.Parse(m1._legajo) > int.Parse(m2._legajo))
            {
                return 1;
            }

            if (int.Parse(m1._legajo) < int.Parse(m2._legajo))
            {
                return -1;
            }

            return 0;
        
        }
        
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Legajo: ");
            sb.AppendLine(this._legajo);
            sb.Append("Especialidad: ");
            sb.AppendLine(this._especialidad.ToString());
            sb.Append("horario de Entrada: ");
            sb.AppendLine(this._horarioEntrada.ToString());

            return sb.ToString();
        
        }





    }
}
