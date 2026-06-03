class Program
{
    static void Main()
    {
        Console.Write("ingrese el precio del producto: $");
        double precio = double.Parse(Console.ReadLine());

        Console.WriteLine("Tipo de IVA:");
        Console.WriteLine("1 - general    (21%)");
        Console.WriteLine("2 - reducida   (10.5%)");
        Console.WriteLine("3 - aumentada  (27%)");
        Console.Write("Seleccione una opcion: ");
        int tipoIva = int.Parse(Console.ReadLine());

        double precioFinal = CalcularIva(precio, tipoIva);

        if (precioFinal > 0)
            Console.WriteLine($"precio con IVA incluido: ${precioFinal}");
        else
            Console.WriteLine("tipo de IVA invalido.");
    }

    static double CalcularIva(double precio, int tipoIva)
    {
        double porcentaje;
        switch (tipoIva)
        {
            case 1: porcentaje = 0.21;  break;
            case 2: porcentaje = 0.105; break;
            case 3: porcentaje = 0.27;  break;
            default: return -1;
        }
        return precio + (precio * porcentaje);
    }
}