using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Estudiante
    {
        private string nombres, apellidos, institucion, cedula;
        public Estudiante(string nombres, string apellidos, string institucion, string cedula)
        {

            this.nombres = nombres;
            this.apellidos = apellidos;
            this.institucion = institucion;
            this.cedula = cedula;
        }
        public void imprimirDatos()
        {

            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Institucion: " + institucion);

        }
    }
}
