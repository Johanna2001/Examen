using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Estudiante_Primaria: Estudiante
    {
        private int valor;
        private int total;
        public Estudiante_Primaria(string nombres, string apellidos, string institucion, string cedula, int valor) : base(nombres, apellidos, institucion, cedula)
        {

            this.valor = valor;
        }
        public void Valor()
        {
            Console.WriteLine("El valor de la matricula es: " + total);
        }

    }
}

