using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        
#region "Atributos"

    private String _nombre;

    private String _apellido;

#endregion

#region "Propiedades"

    public String Nombre
    {
        get {return this._nombre;}

        set{this._nombre = value;}
    }

    public String Apellido{
        get{
            return this._apellido;}

        set{
            this._apellido = value;
        }
    }
#endregion

#region "Constructor"

    public Persona(String nombre, String apellido)
    {
        this._apellido = apellido;
        this._nombre = nombre;

    }
#endregion

#region "Polimorfismo"

    public override String ToString(){

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append(this._apellido);
        sb.Append(", ");
        sb.Append(this._nombre);

        return sb.ToString();

    }

#endregion

    }
}
