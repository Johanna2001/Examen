using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Estudiante_Universitario : Estudiante
    {
        private int valor1;
        private int total;
        public Estudiante_Universitario(string nombres, string apellidos, string institucion, string cedula, int valor1) : base(nombres, apellidos, institucion, cedula)
        {

            this.valor1 = valor1;
            total = valor1 * 7;
        }
        public void creditos()
        {
            Console.WriteLine("El valor de la matricula es: " + total);
        }
    }
}
