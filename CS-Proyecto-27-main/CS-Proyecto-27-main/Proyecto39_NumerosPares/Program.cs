using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto39_NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, numMax=0, pares=0, impares = 0, numero = 0;
            string iLine;

            Console.Write("Ingrese la cantidad de nros que quiere comparar: ");
            iLine = Console.ReadLine();
            numMax = int.Parse(iLine);
            Console.WriteLine();
            while (contador < numMax)
            {
                contador++;
                Console.Write("Ingrese el valor " + contador + ": ");
                iLine = Console.ReadLine();
                numero = int.Parse(iLine);

                if (numero%2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("\nCantidad de valores paraes: " + pares + "\nCanitdad de valores impares: " + impares);
            Console.ReadKey();
        }
    }
}
