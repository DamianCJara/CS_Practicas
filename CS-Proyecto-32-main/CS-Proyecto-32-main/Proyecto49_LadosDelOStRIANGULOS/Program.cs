using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto49_LadosDelOStRIANGULOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0, lado2 = 0, lado3 = 0, cantidadTriangulos = 0, equilatero = 0, isoseles = 0, escaleno = 0;

            Console.Write("Ingrese la cantidad de triangulos que desea calsificar: ");
            cantidadTriangulos = int.Parse(Console.ReadLine());

            for (int i=0; i < cantidadTriangulos; i++)
            {
                Console.Write("\nTriangulo nro: " + (i+1) + "\nIngrtese el primer lado del triangulo: ");
                lado1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segudno lado del triangulo: ");
                lado2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer lado del triangulo: ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1==lado2 && lado2==lado3)
                {
                    equilatero++;
                }
                else
                {
                    if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                    {
                        isoseles++;
                    }
                    else
                    {
                        escaleno++;
                    }
                }
            }

            Console.WriteLine("\nEquilatero: " + equilatero);
            Console.WriteLine("Isoseles: " + isoseles);
            Console.WriteLine("Escaleno: " + escaleno);
            Console.ReadKey();
        }
    }
}
