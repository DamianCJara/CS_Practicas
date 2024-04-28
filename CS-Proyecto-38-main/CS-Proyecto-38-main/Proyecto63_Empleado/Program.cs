using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto63_Empleado
{
    class Empleado
    {
        private string nombre;
        private float sueldo;

        public void Inicializar()
        {
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Su sueldo es: " + sueldo);
        }

        public void Impusetos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Tiene que pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No tiene que pagar impuestos");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Inicializar();
            empleado1.Imprimir();
            empleado1.Impusetos();
            Console.ReadKey();
        }
    }
}
