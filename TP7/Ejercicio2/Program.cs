class Program
{
    static void Main()
    {
        double[] precios = { 15000, 23000, 45000, 8500, 120000, 67000, 32000, 55000 };
        double total = 0;

        Console.WriteLine("lista de precios:");
        foreach (double p in precios)
        {
            Console.WriteLine($"  ${p}");
            total += p;
        }

        double porcentajeDescuento = 0;

        if (total > 600000)
            porcentajeDescuento = 0.20;
        else if (total > 400000)
            porcentajeDescuento = 0.15;
        else if (total > 250000)
            porcentajeDescuento = 0.10;

        double descuento = total * porcentajeDescuento;
        double totalFinal = total - descuento;

        Console.WriteLine();
        Console.WriteLine($"Total de compra:    ${total}");
        if (descuento > 0)
            Console.WriteLine($"descuento ({(int)(porcentajeDescuento * 100)}%):    ${descuento}");
        else
            Console.WriteLine("sin descuento aplicado.");
        Console.WriteLine($"Total a pagar:      ${totalFinal}");
    }
}