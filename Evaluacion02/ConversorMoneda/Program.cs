namespace ConversorMoneda;

class Program
{
    const double TASA_USD = 59.50;

    static void Main(string[] args)
    {

        Console.Write("Monto en pesos (RD$): ");
        double montoPesos = double.Parse(Console.ReadLine());

        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine();
        Console.WriteLine($"Tasa del día: RD${TASA_USD} por US$1");
        Console.WriteLine($"RD${montoPesos} equivalen a US${montoDolares:F2}");
    }
}