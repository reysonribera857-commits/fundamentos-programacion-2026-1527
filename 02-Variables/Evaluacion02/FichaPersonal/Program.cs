namespace FichaPersonal;

class Program
{
    const int ANIO_ACTUAL = 2026;

    static void Main(string[] args)
    {
        // Pedimos los datos al usuario
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Estatura (en metros): ");
        double estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Trabaja? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine());

        int anioNacimiento = ANIO_ACTUAL - edad;
        int anioTreinta = anioNacimiento + 30;

        Console.WriteLine();
        Console.WriteLine("===== FICHA PERSONAL =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en: {anioTreinta}");
    }
}
