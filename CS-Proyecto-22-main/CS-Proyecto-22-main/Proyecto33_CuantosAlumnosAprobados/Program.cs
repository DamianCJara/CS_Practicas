using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto33_CuantosAlumnosAprobados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador=0, nota, alumnosMayores=0, alumnosMenores=0;
            string iLine;

            while (contador < 10)
            {
                contador ++;
                Console.WriteLine(contador);
                Console.Write("Nota del alumno: ");
                iLine = Console.ReadLine();
                nota = int.Parse(iLine);

                if (nota >= 7)
                {
                    alumnosMayores ++;
                }
                else
                {
                    alumnosMenores++;
                }
            }
            Console.WriteLine("\n Alumnos con notas mayore o iguales a 7: " + alumnosMayores);
            Console.WriteLine("Alumnos con notas menores a 7: " + alumnosMenores);
            Console.ReadKey();
        }
    }
}
