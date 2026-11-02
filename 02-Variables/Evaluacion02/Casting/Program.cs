namespace Casting;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos un número con decimales
        Console.Write("Escribe un número con decimales: ");
        double numero = double.Parse(Console.ReadLine());

        // Casting explícito: de double a int, se pierde la parte decimal
        int parteEntera = (int)numero;
        Console.WriteLine($"Número original: {numero}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");

        // Casting implícito: de int a double, C# lo hace solo sin perder datos
        int cantidad = 7;
        double cantidadDecimal = cantidad;
        Console.WriteLine($"int {cantidad} convertido a double (implícito): {cantidadDecimal}");
    }
}