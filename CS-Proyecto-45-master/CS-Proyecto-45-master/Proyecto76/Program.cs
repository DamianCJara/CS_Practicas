public class VectorNElementos
{
    private int[] elementos;

    public void CargarDatos()
    {
        int vectorLength = 0;
        elementos = new int[vectorLength];

        Console.Write("Indique la cantidad de elementos que desea ingresar: ");
        vectorLength = int.Parse( Console.ReadLine() );

        //TODO: Ingresar los elementos mediante un for.
    }

    public void Verificacion()
    {
        int contador = 0 ;
        int menor = elementos[0] ;

        for (int f = 0; f < elementos.Length; f++)
        {
            if (elementos[f] < menor)
            {
                menor = elementos[f];
            }

            else
            {
                if (elementos[f] == menor)
                {
                    contador++;
                }
            }
        }
        Console.WriteLine($"\nEl elemento menor es: {menor}\n Se repite {contador}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        VectorNElementos vector = new VectorNElementos();
        vector.CargarDatos();
        vector.Verificacion();
        Console.ReadKey();
    }
}