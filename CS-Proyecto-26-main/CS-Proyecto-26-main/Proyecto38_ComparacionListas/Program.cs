using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto38_ComparacionListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor=0,list1=0, list2=0, contador=0;
            string iLine;

            Console.WriteLine("Ingrese los valores de la primer lista.");
            while(contador < 15)
            {
                contador++;
                Console.Write("Valor " + contador + ": ");
                iLine = Console.ReadLine();
                valor = int.Parse(iLine);
                list1 += valor;
            }
            contador = 0;
            Console.WriteLine("\nIngrese los valores de la segunda lista");
            while(contador < 15)
            {
                contador++;
                Console.Write("Valor" + contador + ": ");  
                iLine = Console.ReadLine();
                valor = int.Parse(iLine);
                list2 += valor;
            }

            if (list1 > list2)
            {
                Console.WriteLine("\nLista 1 Mayor.");
            }
            else
            {
                if (list1<list2)
                {
                    Console.WriteLine("\nLista 2 Mayor.");
                }
                else
                {
                    Console.WriteLine("\nLas listas son iguales.");
                }
            }
            Console.ReadKey();
        }
    }
}
