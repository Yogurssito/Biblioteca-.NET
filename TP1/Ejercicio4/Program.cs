class Program
{
    static void Main()
    {
        Console.Write("ingrese el precio del articulo: ");
        double precio = double.Parse(Console.ReadLine());
        double descuento = precio * 0.15;
        double precioFinal = precio - descuento;
        Console.WriteLine($"Precio original:  ${precio}");
        Console.WriteLine($"Descuento (15%):  ${descuento}");
        Console.WriteLine($"Precio final:     ${precioFinal}");
    }
}