using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto34_PromedioNAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador=0, cantidadPersonas;
            float alturas = 0, promedio = 0;
            string iLine;

            Console.Write("Ingrese la cantidad de personas a medir: ");
            iLine = Console.ReadLine();
            cantidadPersonas = int.Parse(iLine);

            while (contador < cantidadPersonas)
            {
                contador++;
                Console.WriteLine("\nPersona nro " + contador);
                Console.Write("Altura: ");
                iLine = Console.ReadLine();
                alturas += float.Parse(iLine);
            }
            promedio = alturas / cantidadPersonas;
            Console.WriteLine("\n Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
