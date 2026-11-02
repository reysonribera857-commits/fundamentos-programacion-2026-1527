namespace Factura;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;

        Console.Write("Producto: ");
        string producto = Console.ReadLine();

        Console.Write("Cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        double subtotal = cantidad * precio;
        double itbis = subtotal * ITBIS;
        double total = subtotal + itbis;

        Console.WriteLine();
        Console.WriteLine("FACTURA");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine("Producto".PadRight(15) + "Cant.".PadLeft(6) + "Precio".PadLeft(12) + "Importe".PadLeft(12));
        Console.WriteLine(producto.PadRight(15) + cantidad.ToString().PadLeft(6) + $"{precio,12:N2}" + $"{subtotal,12:N2}");
        Console.WriteLine(new string('-', 45));
        Console.WriteLine("Subtotal:".PadRight(33) + $"{subtotal,12:N2}");
        Console.WriteLine("ITBIS (18%):".PadRight(33) + $"{itbis,12:N2}");
        Console.WriteLine("Total:".PadRight(33) + $"{total,12:N2}");
    }
}