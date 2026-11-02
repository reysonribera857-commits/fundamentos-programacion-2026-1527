namespace Geometria;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cateto 1 del triángulo: ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cateto 2 del triángulo: ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        Console.WriteLine();
        Console.WriteLine($"Área del círculo: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}
