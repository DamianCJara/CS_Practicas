using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_AreaDeUnCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado;
            float area;
            string inputLine;

            Console.Write("Ingrese el valor de un lado de su cuadrado: ");
            inputLine = Console.ReadLine();
            lado= float.Parse(inputLine);
            area = lado * lado;

            Console.WriteLine("El valor del area del cuadrado es:" + area);
            Console.ReadKey();
        }
    }
}
