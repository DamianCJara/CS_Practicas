using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12_IdentificarCantidadCifras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string inputLine;

            Console.Write("Ingrese el numero: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.WriteLine("");
            if ( num1 > 999)
            {
                Console.WriteLine("Error.");
            }
            else
            {
                if (num1 > 99)
                {
                    Console.WriteLine("Tres cifras.");
                }
                else
                {
                    if (num1 > 9)
                    {
                        Console.WriteLine("Dos Cifras.");
                    }
                    else 
                    {
                        Console.WriteLine("Una cifra");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
