using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Eventos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio al objecto de tipo 'Empleado'
            Empleado empleadoEvento = new Empleado();

            //Asocio el evento a su manejador
            empleadoEvento.LimiteSueldo += new LimiteSueldoDel(SobreSueldo_Evento);
            


            //Asigno el nombre
            empleadoEvento.Nombre = "Juan";

            //Esta asignación provoca el evento
            empleadoEvento.Sueldo = 1500;

         

            
        }

        public static void SobreSueldo_Evento(Empleado e, Double importe)
        {
            Console.WriteLine("Se ha sobrepasado, para el empleado {0}, el límite establecido de sueldo",
                              e.Nombre);

            Console.WriteLine();

            Console.WriteLine("El importe de $ {0:#,###.00} no es válido!!!", importe);

            Console.WriteLine();

            Console.ReadLine();
        }
 
    }
}
