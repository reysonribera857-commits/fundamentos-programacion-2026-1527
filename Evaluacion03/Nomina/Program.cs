namespace Nomina;

class Program
{
    static void Main(string[] args)
    {
        const double AFP = 0.0287;
        const double SFS = 0.0304;

        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Horas trabajadas: ");
        double horas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Pago por hora: ");
        double pagoHora = Convert.ToDouble(Console.ReadLine());

        double bruto = horas * pagoHora;
        double descuentoAfp = bruto * AFP;
        double descuentoSfs = bruto * SFS;
        double neto = bruto - descuentoAfp - descuentoSfs;

        Console.WriteLine();
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: {bruto:N2}");
        Console.WriteLine($"AFP (2.87%):   {descuentoAfp:N2}");
        Console.WriteLine($"SFS (3.04%):   {descuentoSfs:N2}");
        Console.WriteLine($"Salario neto:  {neto:N2}");
    }
}
