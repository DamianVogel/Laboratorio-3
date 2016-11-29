using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Curso
    {
        private int _codigoCurso;
        private int _duracion;
        private String _nombre;

        public Curso(int codigoCurso, int duracion, String nombre)
        {
            this._codigoCurso = codigoCurso;
            this._duracion = duracion;
            this._nombre = nombre;
        
        }

      
        public int CodigoCurso
        {
            get { return this._codigoCurso; }
            set { this._codigoCurso = value; }
        }

        
        public int Duracion
        {
            get { return this._duracion; }
            set { this._duracion = value; }
        }

        

        public String Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        
    
    

    
    }
}
