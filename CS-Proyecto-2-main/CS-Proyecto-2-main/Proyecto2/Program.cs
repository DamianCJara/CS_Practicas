using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    /*
        Descripcion.
        El programa calcula el sueldo de un trabajador
        en base a las horas trabajadas.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string inputLine;

            Console.Write("Ingrese las horas laborales: ");
            inputLine= Console.ReadLine();
            horasTrabajadas= int.Parse(inputLine);

            Console.Write("Ingrese el pago por hora de trabajo: ");
            inputLine= Console.ReadLine();
            costoHora= float.Parse(inputLine);

            sueldo = horasTrabajadas * costoHora;

            Console.WriteLine("Su sueldo es de: " + sueldo);
            Console.ReadKey();
        }
    }
}
