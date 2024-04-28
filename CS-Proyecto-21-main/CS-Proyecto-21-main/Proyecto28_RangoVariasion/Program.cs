using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto28_RangoVariasion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mayor, menor;
            string iLine;

            Console.Write("Primer numero: ");
            iLine = Console.ReadLine();
            num1 = int.Parse(iLine);
            Console.Write("Segundo numero: ");
            iLine = Console.ReadLine();
            num2 = int.Parse(iLine);
            Console.Write("Tercer numero: ");
            iLine = Console.ReadLine();
            num3 = int.Parse(iLine);

            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;
                if (num2 > num3)
                {
                    menor = num3;
                }
                else
                {
                    menor = num2;
                }
            }
            else
            {
                if (num1 < num2 && num1 < num3)
                {
                    menor = num1;
                    if (num2 > num3)
                    {
                        mayor = num2;
                    }
                    else
                    {
                        mayor = num3;
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        mayor = num2;
                        menor = num3;
                    }
                    else
                    {
                        mayor = num3;
                        menor = num2;
                    }
                }
            }
            Console.WriteLine("\n" + menor + "-" + mayor);
            Console.ReadKey();
        }
    }
}