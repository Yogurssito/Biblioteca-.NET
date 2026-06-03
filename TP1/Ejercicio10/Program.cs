class Program
{
    static void Main()
    {
        Console.Write("ingrese el precio neto del producto: ");
        double precioNeto = double.Parse(Console.ReadLine());
        double iva = precioNeto * 0.21;
        double precioTotal = precioNeto + iva;
        Console.WriteLine($"precio neto:     ${precioNeto}");
        Console.WriteLine($"monto IVA (21%): ${iva}");
        Console.WriteLine($"precio total:    ${precioTotal}");
    }
}