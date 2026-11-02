namespace _02_Variables;

class Program
{
    const int ANIO_ACTUAL = 2026;

    static void Main(string[] args)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Estatura: ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        int añoNacimiento = ANIO_ACTUAL - edad - 1;

        Console.WriteLine();
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Año de nacimiento: {añoNacimiento}");
    }
}
