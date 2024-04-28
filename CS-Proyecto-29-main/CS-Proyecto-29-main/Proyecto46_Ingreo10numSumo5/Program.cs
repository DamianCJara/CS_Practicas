using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto46_Ingreo10numSumo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, numero=0;

            for (int i=0; i < 10; i++)
            {
                Console.Write("Ingrese el nro " + (i+1) + ": ");
                numero = int.Parse(Console.ReadLine());
                if ( i >= 5)
                {
                    suma += numero;
                }
            }
            Console.WriteLine("\nLa suma de los 5 ultimos nro, es: " + suma);
            Console.ReadLine();
        }
    }
}
