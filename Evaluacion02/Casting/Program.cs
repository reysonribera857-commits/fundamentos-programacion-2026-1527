namespace Casting;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Escribe un número con decimales: ");
        double numero = double.Parse(Console.ReadLine());

        int parteEntera = (int)numero;
        Console.WriteLine($"Número original: {numero}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");

        int cantidad = 7;
        double cantidadDecimal = cantidad;
        Console.WriteLine($"int {cantidad} convertido a double (implícito): {cantidadDecimal}");
    }
}