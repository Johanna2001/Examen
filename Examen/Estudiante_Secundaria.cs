using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Estudiante_Secundaria : Estudiante
    {
            private int  nivel;
            private int total;
            public Estudiante_Secundaria(string nombres, string apellidos, string institucion, string cedula, int nivel) : base(nombres, apellidos, institucion, cedula)
            {

            this.nivel = nivel;
            total = nivel * 20;
            }
        public void matricula()
        {
            Console.WriteLine("El valor de la matricula es: " + total);
        }
        }
    }
