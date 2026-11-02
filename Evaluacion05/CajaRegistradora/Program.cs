namespace CajaRegistradora;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;

        double subtotal = 0;   // acumulador de precios
        int cantidad = 0;      // contador de productos
        double precio;

        // Se repite hasta que el usuario escriba 0
        do
        {
            Console.Write("Precio del producto (0 para terminar): ");
            precio = Convert.ToDouble(Console.ReadLine());

            if (precio > 0)
            {
                subtotal = subtotal + precio;
                cantidad++;
            }
            else if (precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
            }
        } while (precio != 0);

        double itbis = subtotal * ITBIS;
        double total = subtotal + itbis;

        Console.WriteLine();
        Console.WriteLine($"Productos: {cantidad}");
        Console.WriteLine($"Subtotal:  {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): {itbis:N2}");
        Console.WriteLine($"Total:     {total:N2}");
    }
}