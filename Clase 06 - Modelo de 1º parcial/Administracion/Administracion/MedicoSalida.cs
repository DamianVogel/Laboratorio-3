using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion
{
    public class MedicoSalida:Medico
    {
        protected double _salario;
        protected DateTime _egreso;

        public MedicoSalida(Medico unMedico):base(unMedico.Nombre,unMedico.Legajo,unMedico.Especialidad)
        {
            this._egreso = DateTime.Now;
            this._salario = this.calcularSalario();
        
        }

        protected double calcularSalario()
        {
            TimeSpan intervalo = this._egreso.Subtract(this._horarioEntrada);

            double salarioCalculado = 0;
            
            if (this._especialidad == eEspecialidades.Cardiologo)
            {
                salarioCalculado = intervalo.Minutes * 55;                 
            }

            if (this._especialidad == eEspecialidades.Clinico)
            {
                salarioCalculado = intervalo.Minutes * 50;
            }

            if (this._especialidad == eEspecialidades.Pediatra)
            {
                salarioCalculado = intervalo.Minutes * 45;
            }

            return salarioCalculado;
        }





    }
}
