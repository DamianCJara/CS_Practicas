using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto51_Ingresar10ValoreasOredenarlos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativos=0, positivos=0, multiplos15=0, pares=0, numero, bandera=1;

            while (bandera == 1)
            {
                for (int i = 0; i<10; i++)
                {
                    Console.Write("\nIngrese el valor nro " + (i + 1) + ": ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        if (numero>0)
                        {
                            positivos++;
                        }
                    }

                    if (numero % 15 == 0)
                    {
                        multiplos15++;
                    }

                    if (numero % 2 == 0)
                    {
                        pares += numero;
                    }
                }

                Console.WriteLine("\nLa cantidad de numeros negativos ingresados, es: " + negativos);
                Console.WriteLine("La cantidad de numeros positivos ingresados, es: " + positivos);
                Console.WriteLine("La cantidad de numeros multiplos de 15, es: " + multiplos15);
                Console.WriteLine("La cantidad de acumulada de los numeros pares, es de: " + pares);
                Console.ReadKey();
                Console.WriteLine("\nQuire volver a ejecutar el programa?");
                Console.Write("SI(1), NO(2): ");
                bandera = int.Parse(Console.ReadLine());
            }
        }
    }
}
