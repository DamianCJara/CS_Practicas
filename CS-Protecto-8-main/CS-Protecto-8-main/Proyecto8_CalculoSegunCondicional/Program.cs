using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8_CalculoSegunCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, suma, resta, division, producto;
            string inputLine;

            Console.WriteLine("===== OPERACION MATEMATICA SEGUN LA CONDICION =====");
            Console.WriteLine("");
            
            Console.Write("Ingrese el valor del primer numero: ");
            inputLine= Console.ReadLine();
            num1 = float.Parse(inputLine);

            Console.Write("Ingrese el valor del segundo numer: ");
            inputLine = Console.ReadLine();
            num2 = float.Parse(inputLine);

            if (num1 > num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;

                Console.WriteLine("");
                Console.WriteLine("La sume de los dos numeros es: " + suma);
                Console.WriteLine("La resta de los dos numeros es: " + resta);
                Console.ReadKey();
            }
            else if (num1 < num2)
            {
                producto = num1 * num2;
                division = num1 / num2;

                Console.WriteLine("");
                Console.WriteLine("El peoducto entre los dos numeros, es: " + producto);
                Console.WriteLine("La division entre ambos numeros, es: " + division);
                Console.ReadKey();
            }
        }
    }
}
