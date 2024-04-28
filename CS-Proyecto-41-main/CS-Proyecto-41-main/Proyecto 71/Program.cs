using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_71
{
    public class Vectores
    {
        private int[] valores1;
        private int[] valores2;
        private int[] sumaValores;

        public void CargarVectores()
        {
            valores1 = new int[4];
            valores2 = new int[4];

            for (int f = 0; f < 4; f++)
            {
                Console.Write($"Ingrese los valores de la primer variable. Valor numero {f + 1}: ");
                valores1[f] = int.Parse( Console.ReadLine() );
            }

            Console.WriteLine();
            for (int f = 0; f < 4; f++)
            {
                Console.Write($"Ingrese los valores de la segunda variable. Valor numero {f + 1}: ");
                valores2[f] = int.Parse(Console.ReadLine());
            }
        }

        public void SumarVectores()
        {
            sumaValores = new int[4];

            for (int f = 0; f < 4; f++)
            {
                sumaValores[f] = valores1[f] + valores2[f];
            }
        }

        public void ImprimirVectores()
        {
            Console.WriteLine("\nLa suma individual de cada uno de los componentes es: ");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine($"Componente numero {f + 1}: {sumaValores[f]}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vectores vectores = new Vectores();
            vectores.CargarVectores();
            vectores.SumarVectores();
            vectores.ImprimirVectores();
            Console.ReadKey();
        }
    }
}
