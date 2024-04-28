using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16_HayUnNumeroMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string inputLine;

            Console.Write("Primer nro: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.Write("Segundo nro: ");
            inputLine = Console.ReadLine();
            num2 = int.Parse(inputLine);

            Console.Write("Tercer nro: ");
            inputLine = Console.ReadLine();
            num3 = int.Parse(inputLine);

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.Write("Alguno de los tres numeros es menores a 10.");
            }
            Console.ReadKey();
        }
    }
}
