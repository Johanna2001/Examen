using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("Estudiantes");
                    Estudiante_Primaria estudiante_primaria = new Estudiante_Primaria("Maria", "Zambrano", "Jacovo Vera", "1312145122", 100);
                    estudiante_primaria.Valor();
                    estudiante_primaria.imprimirDatos();
                    Console.WriteLine(" ");
                    Console.WriteLine("__________________________");
                    Console.WriteLine(" ");
                    Estudiante_Secundaria estudiante_secundaria = new Estudiante_Secundaria("Carlos", "Parrales", "5 de julio", "12314526455", 5);
                    estudiante_secundaria.matricula();
                    estudiante_secundaria.imprimirDatos();
                    Console.WriteLine(" ");
                    Console.WriteLine("_________________________________");
                    Console.WriteLine(" ");
                    Estudiante_Universitario estudiante_universitario = new Estudiante_Universitario("Pedro", "Pin", "ULEAM", "1234521244", 350);
                    estudiante_universitario.creditos();
                    estudiante_universitario.imprimirDatos();
                }
            }
        }
    }
}
