using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto52_EdadesSegunElTurno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turnoM = 0, turnoT = 0, turnoN = 0, edadesM = 0, edadesT = 0, edadesN = 0, bandera = 1, numero;

            while (bandera == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Turno M");
                    Console.WriteLine("Alumno nro " + (i+1));
                    Console.Write("Ingrese la edad del alumno: ");
                    numero = int.Parse(Console.ReadLine());
                    edadesM += numero;
                    turnoM = edadesM / 2;
                }

                Console.WriteLine("\n");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Turno T");
                    Console.WriteLine("Alumno nro " + (i+1));
                    Console.Write("Ingrese la edad del alumno: ");
                    numero = int.Parse(Console.ReadLine());
                    edadesT += numero;
                    turnoT = edadesT / 3;
                }

                Console.WriteLine("\n");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("\nTurno N");
                    Console.WriteLine("Alumno nro " + (i+1));
                    Console.Write("Ingrese la edad del alumno: ");
                    numero = int.Parse(Console.ReadLine());
                    edadesN += numero;
                    turnoN = edadesN / 4;
                }

                Console.WriteLine("\nEl porsentaje de alumnos en la Mañana, es de " + turnoM);
                Console.WriteLine("El porsentaje de alumnos en la Tarde, es de " + turnoT);
                Console.WriteLine("El porsentaje de alumnos en la Noche, es de " + turnoN);

                if (turnoM < turnoT && turnoM < turnoN)
                {
                    Console.WriteLine("El turno Mañana tiene amyor cantidad de alumnos menores");
                }
                else
                {
                    if (turnoT < turnoN)
                    {
                        Console.WriteLine("El turno Tarde tiene amyor cantidad de alumnos menores");
                    }
                    else
                    {
                        Console.WriteLine("El turno Noche tiene amyor cantidad de alumnos menores");
                    }
                }

                Console.WriteLine("\nQuiere volver a usar el programa?");
                Console.Write("SI(1), NO(2): ");
                bandera = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
        }
    }
}
