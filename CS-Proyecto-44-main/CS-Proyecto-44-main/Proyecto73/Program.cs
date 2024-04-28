using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto73
{
    public class OrdenVectores
    {
        private int[] valores;
        public void CargarValores()
        {
            valores = new int[10];

            for (int f = 0; f < 10; f++)
            {
                Console.Write($"Ingrese el valor numero {f + 1}: ");
                valores[f] = int.Parse( Console.ReadLine() );
            }
        }

        public void VerificarOrden()
        {
            int bandera = 0;

            for (int f = 0; f < 9; f++)
            {
                if (valores[f] < valores[f + 1])
                {
                    bandera++;
                }
            }

            if (bandera == 9)
            {
                Console.WriteLine("\nEstan ordenados");
            }
            else
            {
                Console.WriteLine("\nNo estan ordenados");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OrdenVectores ordenarVectores = new OrdenVectores();

            ordenarVectores.CargarValores();
            ordenarVectores.VerificarOrden();
            Console.ReadKey();
        }
    }
}