using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto65_TablaMultiplicar
{
    class TablaMultiplicar
    {
        public void CargarValor()
        {
            int valor;
            string linea;

            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    if (valor != 0)
                    {
                        Calcular(valor);
                    }
                    else
                    {
                        Console.WriteLine("0 x cualquier nuemero es 0.");
                    }
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargarValor();
        }
    }
}
