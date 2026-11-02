namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Tablas de multiplicar");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    MostrarTablas();
                    break;
                case 2:
                    MostrarTriangulo();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void MostrarTablas()
    {
        Console.WriteLine();
        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columna = 1; columna <= 10; columna++)
            {
                Console.Write($"{fila * columna,4}");
            }
            Console.WriteLine();
        }
    }

    static void MostrarTriangulo()
    {
        Console.Write("¿Cuántas filas quieres?: ");
        int n;
        bool esNumero = int.TryParse(Console.ReadLine(), out n);

        if (!esNumero || n < 1)
        {
            Console.WriteLine("Número inválido. Debe ser un entero mayor que 0.");
        }
        else
        {
            Console.WriteLine();
            for (int fila = 1; fila <= n; fila++)
            {
                for (int i = 1; i <= fila; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
