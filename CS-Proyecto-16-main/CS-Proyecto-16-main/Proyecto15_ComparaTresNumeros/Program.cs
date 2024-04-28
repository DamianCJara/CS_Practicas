using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15_ComparaTresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string inputLine;

            Console.Write("Primer numero: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.Write("Segundo numero: ");
            inputLine = Console.ReadLine();
            num2 = int.Parse(inputLine);

            Console.Write("Tercer nuemro: ");
            inputLine = Console.ReadLine();
            num3 = int.Parse(inputLine);

            if (num1<10 && num2<10 && num3<10)
            {
                Console.Write("Los tres numeros son menores a 10.");
            }
            Console.ReadKey();
        }
    }
}
