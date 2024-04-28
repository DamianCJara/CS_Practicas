using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto36_25terminosDel11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador=0, num = 11;

            while (contador < 25)
            {
                contador++;
                Console.Write("-" + num);
                num += 11;
            }
            Console.ReadKey();
        }
    }
}
