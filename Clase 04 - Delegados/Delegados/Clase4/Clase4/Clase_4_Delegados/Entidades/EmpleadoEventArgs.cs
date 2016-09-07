using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase para guardar información sobre
    /// los eventos lanzados por la clase EmpleadoMejorado;
    /// esta clase en concreto, guardará el valor del sueldo
    /// erróneo que se ha intentado asignar a un empleado.
    /// </summary>
    public class EmpleadoEventArgs : EventArgs
    {
        private Double _sueldo;
        public Double SueldoIntentadoAsignar { get { return this._sueldo; } set { this._sueldo = value; } }


    }
}
