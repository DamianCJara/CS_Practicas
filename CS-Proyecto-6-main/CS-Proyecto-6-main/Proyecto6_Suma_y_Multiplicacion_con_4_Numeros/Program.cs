using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5_Suma_y_Multiplicacion_con_4_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, producto;
            string inputLine;

            Console.WriteLine("===== OPERACIONES CON CUATRO NUMEROS =====");
            Console.WriteLine("");
            Console.Write("Ingrese el primer numero: ");
            inputLine = Console.ReadLine();
            num1 = float.Parse(inputLine);

            Console.Write("Ingrese el segundo numero: ");
            inputLine = Console.ReadLine();
            num2 = float.Parse(inputLine);

            Console.Write("Ingrese el tercer numero: ");
            inputLine = Console.ReadLine();
            num3 = float.Parse(inputLine);

            Console.Write("Ingrese el quinto numero: ");
            inputLine = Console.ReadLine();
            num4 = float.Parse(inputLine);

            suma = num1 + num2;
            producto = num3 * num4;

            Console.WriteLine("");
            Console.WriteLine("La sume del primer numero con el segundo, es: " + suma);
            Console.WriteLine("El producto entre el tercer numero y el cuarto, es: " + producto);

            Console.ReadKey();
        }
    }
}
