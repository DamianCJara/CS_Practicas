using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto70
{
    /*
     * La clase SumaDeElementos, se encarga de pedir al usuario ingresar un 
     * total de 8 valores por teclado y los almacena en un vector. Luego suma el 
     * total de los valores almacenados en el vector, suma el valor almacenado total de los valores
     * mayores a 36 y suma la canitdad de valores ingresados mayores a 50.
     */

    public class SumaDeElementos
    {
        private int[] valores;

        public void CargarValores()
        {
            valores = new int[8];

            for (int f = 0; f < 8; f++)
            {
                Console.Write($"Ingrese el valor numero {f + 1}: ");
                valores[f] = int.Parse(Console.ReadLine());
            }
        }

        public int SumarTodasVariables()
        {
            int suma = 0;

            for (int f = 0; f < 8; f++)
            {
                suma += valores[f];
            }

            return suma;
        }

        public int SumarMayores36()
        {
            int suma = 0;

            for (int f = 0; f < 8; f++)
            {
                if (valores[f] > 36)
                {
                    suma += valores[f];
                }
            }

            return suma;
        }

        public int CantidadMayores50()
        {
            int suma = 0;

            for ( int f = 0; f < 8; f++)
            {
                if (valores[f] > 50)
                {
                    suma++;
                }
            }

            return suma;
        }

        public void ImprimirValores()
        {
            Console.WriteLine($"\nEl total de los valores ingresados, es: {SumarTodasVariables()}");
            Console.WriteLine($"El total acumulado de los valores mayores a 36, es de: {SumarMayores36()}");
            Console.WriteLine($"El total de los valores ingresados mayores a 50, es de: {CantidadMayores50()}");
            Console.ReadKey();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SumaDeElementos calculosValores = new SumaDeElementos();

            calculosValores.CargarValores();
            calculosValores.ImprimirValores();
        }
    }
}
