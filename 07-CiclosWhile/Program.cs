namespace _07_CiclosWhile;

class Program
{
    static void Main(string[] args)
    {
        // 1. Pedir un número entre 1 y 12 (se repite hasta que sea válido)
        int numero;
        bool esNumero;

        do
        {
            Console.Write("Escribe un número entre 1 y 12: ");
            esNumero = int.TryParse(Console.ReadLine(), out numero);

            if (!esNumero || numero < 1 || numero > 12)
            {
                Console.WriteLine("Número inválido. Intenta de nuevo.");
            }
        } while (!esNumero || numero < 1 || numero > 12);

        // 2. Tabla de multiplicar del 1 al 12 con while
        Console.WriteLine();
        Console.WriteLine($"Tabla del {numero}:");

        int contador = 1;
        int suma = 0;

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // 3. Acumulador
            suma = suma + resultado;

            contador++;
        }

        Console.WriteLine();
        Console.WriteLine($"Suma de todos los resultados: {suma}");
    }
}