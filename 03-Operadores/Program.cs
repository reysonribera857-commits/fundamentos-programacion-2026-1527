namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("3 (x): ");
        int x = int.Parse(Console.ReadLine()!);

        Console.Write("2(y): ");
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine();
        Console.WriteLine($"Suma:            {x} + {y} = {x + y}");
        Console.WriteLine($"Resta:           {x} - {y} = {x - y}");
        Console.WriteLine($"Producto:        {x} * {y} = {x * y}");

        if (y != 0)
        {
            Console.WriteLine($"División real:   {x} / {y} = {(double)x / y}");
            Console.WriteLine($"División entera: {x} / {y} = {x / y}");
            Console.WriteLine($"Residuo:         {x} % {y} = {x % y}");
        }
        else
        {
            Console.WriteLine("División real:   no se puede dividir entre cero");
            Console.WriteLine("División entera: no se puede dividir entre cero");
            Console.WriteLine("Residuo:         no se puede dividir entre cero");
        }

        bool esPar = x % 2 == 0;
        Console.WriteLine($"¿{x} es par?     {esPar}");
    }
}