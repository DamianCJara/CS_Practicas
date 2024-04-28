using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto27_AymentoParaOperario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            int years;
            string iLine;

            Console.Write("Ingrese su sueldo actual: $");
            iLine = Console.ReadLine();
            sueldo = float.Parse(iLine);

            Console.Write("Anios de antiguedad: $");
            iLine = Console.ReadLine();
            years = int.Parse(iLine);

            Console.WriteLine();
            if ( sueldo < 500 && years > 10)
            {
                sueldo = (sueldo * 0.20f) + sueldo;
                Console.WriteLine("Sueldo actual: $" + sueldo);
            }
            else
            {
                if (sueldo < 500 && years < 10)
                {
                    sueldo = (sueldo * 0.05f) + sueldo;
                    Console.WriteLine("Sueldo actual: $" + sueldo);
                }
                else
                {
                    Console.WriteLine("Su sueldo: $" + sueldo);
                }
            }
            Console.ReadKey();
        }
    }
}
