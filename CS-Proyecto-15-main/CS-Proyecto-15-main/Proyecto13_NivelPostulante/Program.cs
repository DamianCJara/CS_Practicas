using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13_NivelPostulante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPreguntas, cantidadCorrectas, porcentaje;
            string inputLine;

            Console.Write("Ingrese la cantidad de prguntas: ");
            inputLine= Console.ReadLine();
            cantidadPreguntas= int.Parse(inputLine);

            Console.Write("Ingrese la cantidad de preguntas correctas: ");
            inputLine= Console.ReadLine();
            cantidadCorrectas= int.Parse(inputLine);

            porcentaje = (cantidadCorrectas * 100) / cantidadPreguntas;

            Console.WriteLine("");
            if (porcentaje >= 90)
            {
                Console.WriteLine("Nivel maximo.");
            }
            else
            {
                if (porcentaje >= 75)
                {
                    Console.WriteLine("Nivel medio.");
                }
                else 
                {
                    if (porcentaje >= 50)
                    {
                        Console.WriteLine("Nivel regular.");
                    }
                    else
                    {
                        Console.WriteLine("Fuera de Nivel");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
