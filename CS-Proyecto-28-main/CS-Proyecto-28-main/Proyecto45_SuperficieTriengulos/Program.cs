using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto45_SuperficieTriengulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo = 0, alturaTrinagulo = 0,superficie = 0, cantidadTriangulos = 0, triangulosMayores = 0;
            string iLine;

            Console.Write("Ingrgese la cantidad de triangulos a procesar: ");
            cantidadTriangulos = int.Parse(Console.ReadLine());

            for (int i=0; i<cantidadTriangulos; i++)
            {
                Console.Write("\nIngrese la base del triangulo: ");
                baseTriangulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triangulo: ");
                alturaTrinagulo = int.Parse(Console.ReadLine());

                superficie = baseTriangulo * (alturaTrinagulo / 2);
                Console.WriteLine("La suoprficie del triangulo es: " + superficie);

                if ( superficie > 12)
                {
                    triangulosMayores++;
                }
            }
            Console.WriteLine("\nLa cantidad de triangulos con superficie mayor a 12, son : " + triangulosMayores);
            Console.ReadLine();
        }
    }
}
