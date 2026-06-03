class Program
{
    static void Main()
    {
        double totalInventario = 0;

        while (true)
        {
            Console.Write("nombre del producto (vacio para terminar): ");
            string nombre = Console.ReadLine()!;

            if (string.IsNullOrEmpty(nombre))
                break;

            double precio;
            do
            {
                Console.Write("precio (debe ser > 0): $");
                precio = double.Parse(Console.ReadLine());
                if (precio <= 0)
                    Console.WriteLine("el precio debe ser mayor a 0.");
            }
            while (precio <= 0);

            int cantidad;
            do
            {
                Console.Write("cantidad (debe ser >= 0): ");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 0)
                    Console.WriteLine("la cantidad debe ser mayor o igual a 0.");
            }
            while (cantidad < 0);

            double valorProducto = precio * cantidad;
            totalInventario += valorProducto;
            Console.WriteLine($"valor total de '{nombre}': ${valorProducto}");
            Console.WriteLine("---");
        }

        Console.WriteLine($"valor total del inventario: ${totalInventario}");
    }
}