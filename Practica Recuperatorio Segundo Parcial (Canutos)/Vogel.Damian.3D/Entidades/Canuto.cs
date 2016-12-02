using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Canuto
    {
        private int _id;
        private String _nombre;
        private String _apellido;
        private Double _dolares;
        private int _codEscondite;

        public Canuto(int id, string nombre, string apellido, double dolares, int codEscondite)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._dolares = dolares;
            this._codEscondite = codEscondite;     
        }

        public int Id { get {return this._id;} }
        public String Nombre { get { return this._nombre; } }
        public String Apellido { get { return this._apellido; } }
        public Double Dolares { get { return this._dolares; } }
        public int CodEscondite { get { return this._codEscondite; } }
    
    }
}
