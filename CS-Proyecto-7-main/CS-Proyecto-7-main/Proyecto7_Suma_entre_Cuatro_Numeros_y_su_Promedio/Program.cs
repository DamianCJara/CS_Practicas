using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto7_Suma_entre_Cuatro_Numeros_y_su_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, promedio;
            string inputLine;
            Console.WriteLine("===== SUMA DE CUATRO NUMEROS Y SU PROMEDIO =====");
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

            Console.Write("Ingrese el cuarto numero: ");
            inputLine = Console.ReadLine();
            num4 = float.Parse(inputLine);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine("");
            Console.WriteLine("La sumatoria de los cuatro numeros es: " + suma);
            Console.WriteLine("El promedio de la suma es: " + promedio);
            Console.ReadKey();
        }
    }
}
