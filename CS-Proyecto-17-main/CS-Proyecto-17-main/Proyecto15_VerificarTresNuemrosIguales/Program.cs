using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15_VerificarTresNuemrosIguales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string inputLine;

            Console.Write("Ingrese el primer nro: ");
            inputLine = Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.Write("Ingrese el segundmo nro: ");
            inputLine = Console.ReadLine();
            num2 = int.Parse(inputLine);

            Console.Write("Ingrese el tecer nro: ");
            inputLine = Console.ReadLine();
            num3 = int.Parse(inputLine);

            if (num1 == num2 && num2 == num3)
            {
                int suma = num1 + num2;
                Console.Write("Resultado de la suma: " + suma);
                int multiplicacion = suma * num3;
                Console.WriteLine("Resultado de la multiplicacion de la suma: " + multiplicacion);
            }
            Console.ReadLine();
        }
    }
}
