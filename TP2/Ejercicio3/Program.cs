class Program
{
    static void Main()
    {
        Console.WriteLine("=== Catalogo de Alimentos ===");
        Console.WriteLine("1 - Dogui x 21 kg       | Normal: $38.000 | x5-10: $36.000 | +11: $34.000");
        Console.WriteLine("2 - Tiernitos x 21 kg   | Normal: $31.000 | x5-10: $29.000 | +11: $27.000");
        Console.WriteLine("3 - Dogpro x 21 kg      | Normal: $46.000 | x5-10: $44.000 | +11: $42.000");
        Console.Write("ingrese el codigo del producto: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("ingrese la cantidad de bolsas: ");
        int cantidad = int.Parse(Console.ReadLine());

        double precioUnitario;

        if (codigo == 1)
        {
            if (cantidad >= 11)
                precioUnitario = 34000;
            else if (cantidad >= 5)
                precioUnitario = 36000;
            else
                precioUnitario = 38000;
        }
        else if (codigo == 2)
        {
            if (cantidad >= 11)
                precioUnitario = 27000;
            else if (cantidad >= 5)
                precioUnitario = 29000;
            else
                precioUnitario = 31000;
        }
        else if (codigo == 3)
        {
            if (cantidad >= 11)
                precioUnitario = 42000;
            else if (cantidad >= 5)
                precioUnitario = 44000;
            else
                precioUnitario = 46000;
        }
        else
        {
            Console.WriteLine("codigo de producto invalido.");
            return;
        }

        double total = precioUnitario * cantidad;
        Console.WriteLine($"Precio unitario: ${precioUnitario}");
        Console.WriteLine($"Importe total a pagar: ${total}");
    }
}