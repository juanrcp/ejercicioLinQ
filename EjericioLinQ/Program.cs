internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("LISTADO DE DIVISORES DEL NUERO 7\n");

        //Lista donde guardamos los numero del 1-100
        List<int> num = new List<int>(); ;

        //Llenamos la lista
        for (int i = 1; i <= 100; i++)
        {
            num.Add(i);
        }

        //Aqui realizamos el filtrado por los divisores del 7 
        var divisores = num.Where(x => x % 7 == 0);

        //Mostramos divisores
        foreach (int div in divisores)
        {
            Console.Write(div + " ");
        }

        Console.WriteLine();

        //Filtrado para obtener los pares
        var pares = divisores.Where(x => x % 2 == 0);
        //Filtrado para obtener los pares
        var impares = divisores.Where(x => x % 2 != 0);

        //Mostramos divisores pares
        Console.WriteLine("\nLISTA DIVISORES DE 7 PARES\n");
        foreach (int par in pares)
        {
            Console.Write(par + " ");
        }

        //Mostramos divisores impares
        Console.WriteLine("\n\nLISTA DIVISORES DE 7 IMPARES\n");

        foreach (int impar in impares)
        {
            Console.Write(impar + " ");
        }

        Console.WriteLine();

    }
}