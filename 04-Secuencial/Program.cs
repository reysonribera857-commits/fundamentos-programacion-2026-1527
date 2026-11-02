namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
        const double LIBRA_A_KG = 0.453592;

        Console.Write("155: ");
        double libras = Convert.ToDouble(Console.ReadLine());

        Console.Write("212 °F: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double kilogramos = libras * LIBRA_A_KG;
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine();
        Console.WriteLine($"{libras:F2} libras equivalen a {kilogramos:F2} kg");
        Console.WriteLine($"{fahrenheit:F2} °F equivalen a {celsius:F2} °C");
    }
}