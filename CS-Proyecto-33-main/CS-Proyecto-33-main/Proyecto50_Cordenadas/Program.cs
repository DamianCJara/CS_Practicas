using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto50_Cordenadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0, x = 0, y = 0, primerCuadrante = 0, segundoCuadrante = 0, tercerCuadrante = 0, cuartoCuadrante = 0;

            Console.Write("Indique la cantidad de puntos en el plano: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\nPunto nro: " + (i + 1));
                Console.Write("Ingrese X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Y: ");
                y = int.Parse(Console.ReadLine());

                if (x >0 && y>0)
                {
                    primerCuadrante++;
                }
                else
                {
                    if (x<0 && y>0)
                    {
                        segundoCuadrante++;
                    }
                    else
                    {
                        if (x<0 && y<0)
                        {
                            tercerCuadrante++;
                        }
                        else
                        {
                            if (x>0 && y<0)
                            {
                                cuartoCuadrante++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("El primer cuadrante tiene" + primerCuadrante + " punto/s.");
            Console.WriteLine("El segundo cuadrante tiene" + segundoCuadrante + " punto/s.");
            Console.WriteLine("El tercer cuadrante tiene" + tercerCuadrante + " punto/s.");
            Console.WriteLine("El cuarto cuadrante tiene" + cuartoCuadrante + " punto/s.");
            Console.ReadKey();
        }
    }
}
