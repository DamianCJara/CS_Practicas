using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11_PositivoNegatovoNulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string inputLine;

            Console.Write("Ingrese un numero: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.WriteLine("");
            if (num1 == 0)
            {
                Console.WriteLine("Es nulo.");
            }
            else
            {
                if (num1 > 0)
                {
                    Console.WriteLine("Es positivo.");
                }
                else
                {
                    Console.WriteLine("Es negativo.");
                }
            }
            Console.ReadKey();
        }
    }
}
