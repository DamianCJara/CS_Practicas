using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto47_TablaMultiplicar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar por 5 hasta 50\n");
            for (int i = 0; i == 50; i++)
            {
                Console.WriteLine(i + " x 5 = " + (i * 5));
            }
            Console.ReadLine();
        }
    }
}
