using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto57_BancoCuentaCorriente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCuenta, bandera;
            float saldo, totalAcredores;
            bandera = 1;
            totalAcredores = 0; //Como es un acumulador, lo seteamos en cero.

            while (bandera == 1)
            {
                do
                {
                    Console.Write("Ingrese el numero de cuenta: ");
                    numeroCuenta = int.Parse(Console.ReadLine());

                    if (numeroCuenta >= 0)
                    {
                        Console.Write("Ingresa el saldo: $");
                        saldo = float.Parse(Console.ReadLine());

                        Console.Write("Estado de la cuenta: ");
                        if (saldo > 0)
                        {
                            Console.Write("Acredor");
                        }
                        else
                        {
                            if (saldo < 0)
                            {
                                Console.Write("Deudor");
                            }
                            else
                            {
                                Console.Write("Nulo");
                            }
                        }
                        totalAcredores += saldo;
                        Console.WriteLine("\n");
                    }
                } while (numeroCuenta >= 0);
            
                Console.WriteLine("La suma total de los Acredores, es de: $" + totalAcredores);
                Console.WriteLine("\nIngresa 1 para volver al programa o 0 para salir");
                Console.Write("Continuar? ");
                bandera = int.Parse(Console.ReadLine());
            }
        }
    }
}
