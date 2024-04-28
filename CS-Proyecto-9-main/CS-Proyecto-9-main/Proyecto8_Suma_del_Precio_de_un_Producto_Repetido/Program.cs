using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8_Suma_del_Precio_de_un_Producto_Repetido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables a utilizar.
            string inputLine, nombreProducto;
            int cantidadProducto;
            float precioProducto, precioTotal;
            
            // Solicitud de los datos
            Console.WriteLine("===== CAJA REGISTRADORA =====");
            Console.WriteLine("");

            Console.WriteLine("Indique el producto que lleva.");
            Console.Write("Producto: ");
            nombreProducto = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Indique la cantidad del producto.");
            Console.Write("Cantida: ");
            inputLine = Console.ReadLine();
            
            cantidadProducto = int.Parse(inputLine);

            Console.WriteLine();
            Console.WriteLine("Indique el precio del producto.");
            Console.Write("Precio: $");
            inputLine = Console.ReadLine();
            precioProducto = float.Parse(inputLine);

            precioTotal = cantidadProducto * precioProducto;

            Console.WriteLine("");
            Console.WriteLine("Los/las " + cantidadProducto + " de " + nombreProducto + " le costaran: $" + precioTotal);
            Console.ReadKey();

            


        }
    }
}
