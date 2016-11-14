using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogel.Damian
{
    public class Alumno
    {
        private string _apellido;
        private int _codCurso;
        private int _legajo;

        public Alumno(string apellido, int codCurso, int legajo)
        {
            this._apellido = apellido;
            this._codCurso = codCurso;
            this._legajo = legajo;
        }

        public string Apellido { get { return this._apellido; } set {this._apellido=value;} }
        public int codCurso { get { return this._codCurso; } set { this._codCurso = value; } }
        public int legajo { get { return this._legajo; } set { this._legajo = value; } }    


    }
}
