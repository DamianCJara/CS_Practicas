using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5_Perimetro_de_un_Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado, perimetro;
            string inputLine;

            Console.WriteLine("==== PERIMETRO DE UN CUADRADO ====");
            Console.Write("Ingrese la mediada de uno de los lados del cuadrado: ");
            inputLine = Console.ReadLine();
            lado = float.Parse(inputLine);

            perimetro = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.ReadLine();
        }
    }
}
