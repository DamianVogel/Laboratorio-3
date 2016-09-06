using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleado:Persona
    {

    #region "Atributos"

        private String _legajo;

    #endregion

    #region "Propiedades"

        public String Legajo 
        { get{ return this._legajo;}
          set{this._legajo = value;}
        }

    #endregion

    #region "Constructor"

        public Empleado(String nombre, String apellido, String legajo):base(nombre, apellido)
        {
            this._legajo = legajo;
        }
    
    #endregion

    #region "Polimorfismo"

    public override String ToString(){

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append(base.ToString());
        sb.Append(" - Legajo: ");
        sb.Append(this._legajo);

        return sb.ToString();

    }
    #endregion

    }
}
