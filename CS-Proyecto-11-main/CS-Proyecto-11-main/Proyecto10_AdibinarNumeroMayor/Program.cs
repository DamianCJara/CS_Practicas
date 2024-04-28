using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10_AdibinarNumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string inputLine;

            Console.Write("Ingrese el primer numero: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.Write("Ingrese el segundo numero: ");
            inputLine = Console.ReadLine();
            num2 = int.Parse(inputLine);

            Console.Write("Ingrese el tercer numero: ");
            inputLine = Console.ReadLine();
            num3 = int.Parse(inputLine);

            Console.WriteLine("");
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El numero mayor es: "+ num1);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El numero mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + num3);
                }
            }
            Console.ReadKey();
        }
    }
}
