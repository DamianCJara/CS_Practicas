using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10_DectecarCantidadNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string inputLine;

            Console.WriteLine("===== VERIFICAR LA SI EL NUMERO CUETNA CON UNO O DOS DIGITOS =====");
            Console.WriteLine("");

            Console.Write("Ingrese un numero entero entre el 0 y el 99: ");
            inputLine = Console.ReadLine();
            num = int.Parse(inputLine);

            Console.WriteLine("");
            if(num > 0 && num < 10)
            {
                Console.WriteLine("El numero solo esta compuesto por un digito.");
            }
            else if (num > 10 && num <100)
            {
                Console.WriteLine("El numero ingresado esta compuesto por dos digitos.");
            }
            else
            {
                Console.WriteLine("No entendio el jeugo.");
            }
            Console.ReadKey();
        }
    }
}
