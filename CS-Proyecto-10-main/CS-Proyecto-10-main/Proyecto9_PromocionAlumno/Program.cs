using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto9_PromocionAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            string inputLine;

            Console.WriteLine("===== PROMOCION DEL ALUMNO =====");
            Console.WriteLine("");

            Console.Write("Ingrese la primer nota del alumnon: ");
            inputLine = Console.ReadLine();
            nota1 = float.Parse(inputLine);

            Console.Write("Ingrese la segunda nota del alumno: ");
            inputLine = Console.ReadLine();
            nota2 = float.Parse(inputLine);

            Console.Write("Ingrese la tercer nota del alumno: ");
            inputLine = Console.ReadLine();
            nota3 = float.Parse(inputLine);
            Console.WriteLine("");

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("##### Promocionado #####");
            }
            else
            {
                Console.WriteLine("XXXXX No promocionado XXXXX");
            }

            Console.ReadKey();
        }
    }
}
