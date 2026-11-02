namespace _06_Decisiones;

class Program
{
    static void Main(string[] args)
    {
        // PARTE 1: CALIFICACIÓN
        Console.WriteLine("=== CALIFICACIÓN ===");
        Console.Write("Escribe la nota (0-100): ");
        int nota;
        bool esNumero = int.TryParse(Console.ReadLine(), out nota);

        if (!esNumero || nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota inválida. Debe ser un número entre 0 y 100.");
        }
        else if (nota >= 90)
        {
            Console.WriteLine("Letra: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Letra: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Letra: C");
        }
        else
        {
            Console.WriteLine("Letra: F");
        }

        // PARTE 2: CALCULADORA
        Console.WriteLine();
        Console.WriteLine("=== CALCULADORA ===");
        Console.Write("Escribe el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escribe el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Elige una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}