namespace AdivinaNumero;

class Program
{
    static void Main(string[] args)
    {
        
        int secreto = Random.Shared.Next(1, 101);
        int intentos = 0;   // contador de intentos
        int numero;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        do
        {
            Console.Write("Tu número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (numero < secreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (numero > secreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
        } while (numero != secreto);

        Console.WriteLine($"¡Acertaste! Lo lograste en {intentos} intentos.");
    }
}