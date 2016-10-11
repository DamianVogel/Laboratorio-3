using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Class1
    {
        private int _cantidad;
        private string _marca;
        private int _precio;

        public Class1(int cantidad, string marca, int precio)
        {
            this._cantidad = cantidad;
            this._marca = marca;
            this._precio = precio;
        }

        public int Cantidad { get { return this._cantidad; } set {this._cantidad=value;} }
        public string Marca { get { return this._marca; } set { this._marca = value; } }
        public int Precio { get { return this._precio; } set {this._precio=value;} }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("La cantidad es:");
            sb.AppendLine(this._cantidad.ToString());
            sb.Append("La marca es:");
            sb.AppendLine(this._marca);
            sb.Append("El precio es:");
            sb.AppendLine(this._precio.ToString());

            return sb.ToString();


        }

        public static int CompararPrecio(Class1 a, Class1 b)
        {
            int c = 2;

            if (a._precio > b._precio)
            {
                c = 1;
            }

            if (a._precio < b._precio)
            {
                c = -1;
            }

            if (a._precio == b._precio)
            {
                c = 0;
            }



            return c;
        }

        



    
    }
}
