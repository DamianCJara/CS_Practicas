using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto72

    /* DESCRIPCION DEL PROGRAMA
     * 
     * Este programa se encarga de calcular el promedio general que obtuvieron dos cursos, el A y el B, en el primer parcial
     * e indicar cual fue el curso que obtumo el mejor promedio.
     */
{
    public class PrimerParcial
    {
        private int[] cursoA;
        private int[] cursoB;

        public void CargarDatos()
        {
            cursoA = new int[5];
            cursoB = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i + 1} del curso A: ");
                cursoA[i] = int.Parse( Console.ReadLine() );
            }

            Console.WriteLine();
            for (int i =0; i < 5; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i + 1} del curso B: ");
                cursoB[i] = int.Parse( Console.ReadLine() );
            }
        }

        public char CalcularPromedio()
        {
            int promedioA = 0, promedioB = 0;
            char mayor;

            for (int i = 0; i < 5; i++)
            {
                promedioA += cursoA[i];
            }

            for (int i = 0; i < 5; i++)
            {
                promedioB += cursoB[i];
            }

            promedioA /= 5;
            promedioB /= 5;

            if (promedioA > promedioB)
            {
                mayor = 'A';
            }
            else
            {
                mayor = 'B';
            }
            return mayor;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("\nEl curso que obtumo un mayor promedio general, es el: " + CalcularPromedio());
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimerParcial primerParcial = new PrimerParcial();

            primerParcial.CargarDatos();
            primerParcial.CalcularPromedio();
            primerParcial.ImprimirResultado();
            Console.ReadKey();
        }
    }
}
