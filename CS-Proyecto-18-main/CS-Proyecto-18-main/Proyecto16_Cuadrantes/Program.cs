using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16_Cuadrantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string inputLine;

            Console.Write("Ingrese le nro entero de la primer coordenada: ");
            inputLine = Console.ReadLine();
            x = int.Parse(inputLine);

            Console.Write("Ingrese el segundo nro entero de la segunda coordenada: ");
            inputLine = Console.ReadLine();
            y = int.Parse(inputLine);

            if ( x>0 && y>0 )
            {
                Console.Write("Prime Cuadrante.");
            }
            else
            {
                if ( x<0 && y>0 )
                {
                    Console.Write("Segundo Cuadrante.");
                }
                else
                {
                    if ( x<0 && y<0 )
                    {
                        Console.Write("Tercer Cuadrante.");
                    }
                    else
                    {
                        if ( x>0 && y<0 )
                        {
                            Console.Write("Cuarto Cuadrante.");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
