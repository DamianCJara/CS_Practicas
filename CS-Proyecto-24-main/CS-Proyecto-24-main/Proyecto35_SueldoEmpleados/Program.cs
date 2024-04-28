using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto35_SueldoEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados, contador=0, sueldoMenor=0, sueldoMayor=0;
            float sueldo, sueldoTotal=0;
            string iLine;

            Console.Write("Ingrese la cantidad de empleados: ");
            iLine = Console.ReadLine();
            cantidadEmpleados = int.Parse(iLine);

            while (contador < cantidadEmpleados)
            {
                contador++;
                Console.WriteLine("\nEmpleado nro: " + contador);
                Console.Write("Sueldo: ");
                iLine = Console.ReadLine();
                sueldo = float.Parse(iLine);

                if(sueldo >= 100 && sueldo <= 300)
                {
                    sueldoMenor ++;
                    sueldoTotal += sueldo;
                }
                else
                {
                    if (sueldo > 300)
                    {
                        sueldoMayor ++;
                        sueldoTotal += sueldo;
                    }
                }
            }
            Console.WriteLine("\nEl total invertido por la empresa: $" + sueldoTotal);
            Console.WriteLine("La canitdad de empleados que cobran entre $100 y $300: " + sueldoMenor);
            Console.WriteLine("La cantidad de empleados que cobran mas de $300: " + sueldoMayor);
            Console.ReadKey();
        }
    }
}
