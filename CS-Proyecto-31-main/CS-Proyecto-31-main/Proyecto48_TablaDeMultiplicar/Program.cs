using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto48_TablaDeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Ingrese el numero a multiplicar: ");
            Console.WriteLine("\n");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(i + "x" + numero + "=" + (i*numero));
            }
            Console.ReadKey();
        }
    }
}
