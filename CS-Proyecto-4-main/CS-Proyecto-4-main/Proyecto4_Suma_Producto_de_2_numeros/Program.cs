using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4_Suma_Producto_de_2_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            string inputLine;

            Console.WriteLine("===== SUMA Y PRODUCTO DE DOS NUMEROS ENTEROS =====");
            Console.WriteLine("");
            Console.Write("Ingrese el primer numero: ");
            inputLine= Console.ReadLine();
            num1 = int.Parse(inputLine);

            Console.Write("Ingrese el segundo numero: ");
            inputLine = Console.ReadLine();
            num2 = int.Parse(inputLine);

            suma = num1 + num2;
            producto = num1 * num2;

            Console.WriteLine("La sume de los dos numeros es: " + suma);
            Console.WriteLine("El producto de los dos numeros es: " + producto);

            Console.ReadLine();
        }
    }
}
