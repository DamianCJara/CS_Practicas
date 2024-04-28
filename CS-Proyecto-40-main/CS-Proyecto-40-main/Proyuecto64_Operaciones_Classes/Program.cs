using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyuecto64_Operaciones_Classes
{
    class Operaciones
    {
        int val1, val2;

        public void CargarDatos()
        {
            Console.Write("Primer valor: ");
            val1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            val2 = int.Parse(Console.ReadLine());
        }

        public void Sumar()
        {
            int suma = val1 + val2;
            Console.WriteLine("Suma: " + suma);
        }

        public void Restar()
        {
            int resta = val1 - val2;
            Console.WriteLine("Resta: " + resta);
        }

        public void Multiplicar()
        {
            int multiplicacion = val1 * val2;
            Console.WriteLine("Multiplicacion: " + multiplicacion);
        }

        public void Divicion()
        {
            int divicion = val1 / val2;
            Console.WriteLine("Divicion: " + divicion);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int eleccion = 1;
            Operaciones operaciones = new Operaciones();

            do
            {
                operaciones.CargarDatos();
                operaciones.Sumar();
                operaciones.Restar();
                operaciones.Multiplicar();
                operaciones.Divicion();

                Console.WriteLine("Repeti: SI(1) NO(0)");
                Console.Write("Eleccion: ");
                eleccion = int.Parse(Console.ReadLine());
            }while(eleccion != 0);

            Console.WriteLine("Fin de ejecucion");
            Console.ReadKey();
        }
    }
}
