class Program
{
    static void Main()
    {
        Console.Write("ingrese la cantidad de pasajes: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Write("ingrese el importe por pasaje: $");
        double precioPasaje = double.Parse(Console.ReadLine());

        double total = cantidad * precioPasaje;
        double descuento = 0;
        string tipoDescuento = "sin descuento";

        if (cantidad > 3 && total > 500000)
        {
            descuento = total * 0.15;
            tipoDescuento = "15%";
        }
        else if (cantidad > 3 && total > 250000)
        {
            descuento = total * 0.11;
            tipoDescuento = "11%";
        }

        double totalFinal = total - descuento;

        Console.WriteLine($"Subtotal:          ${total}");
        Console.WriteLine($"Descuento ({tipoDescuento}): ${descuento}");
        Console.WriteLine($"Total a pagar:     ${totalFinal}");
    }
}