using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto56_SumaValoresHastaIndicaraLoContrario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sumar, valor;
            sumar= 0;

            do
            {
                Console.WriteLine("\nIngrese el un valor (9999 para finalizar)");
                Console.Write("Valor: ");
                valor = float.Parse(Console.ReadLine());
                if (valor != 9999)
                {
                    sumar += valor;
                }
            } while (valor != 9999);

            if (sumar == 0)
            {
                Console.WriteLine("El valor cumulado es: 0");
            }
            else
            {
                if (sumar > 0)
                {
                    Console.WriteLine("El valor acumulado es mayor a 0: " + sumar);
                }
                else
                {
                    Console.WriteLine("El valor acumulado es menor a 0: " + sumar);
                }
            }
            Console.ReadKey();
        }
    }
}
