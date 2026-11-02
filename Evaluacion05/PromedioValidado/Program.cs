namespace PromedioValidado;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;       // acumulador de notas
        int cantidad = 0;   // contador de notas
        int mayor = 0;
        int menor = 100;
        int nota = 0;
        do
        {
            bool esNumero;

            do
            {
                Console.Write("Escribe una nota (0-100, -1 para terminar): ");
                esNumero = int.TryParse(Console.ReadLine(), out nota);

                if (!esNumero || nota < -1 || nota > 100)
                {
                    Console.WriteLine("Nota inválida. Intenta de nuevo.");
                }
            } while (!esNumero || nota < -1 || nota > 100);

            if (nota != -1)
            {
                suma = suma + nota;
                cantidad++;

                if (nota > mayor)
                {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }
        } while (nota != -1);

        Console.WriteLine();
        if (cantidad == 0)
        {
            Console.WriteLine("No escribiste ninguna nota.");
        }
        else
        {
            double promedio = (double)suma / cantidad;
            Console.WriteLine($"Promedio: {promedio:N2}");
            Console.WriteLine($"Nota mayor: {mayor}");
            Console.WriteLine($"Nota menor: {menor}");
        }
    }
}