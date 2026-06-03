class Program
{
    static void Main()
    {
        Console.Write("ingrese un numero (0 para terminar): ");
        double numero = double.Parse(Console.ReadLine()!);

        if (numero == 0)
        {
            Console.WriteLine("no se ingresaron numeros.");
            return;
        }

        double mayor = numero;

        while (numero != 0)
        {
            if (numero > mayor)
                mayor = numero;

            Console.Write("ingrese un numero (0 para terminar): ");
            numero = double.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"el numero mayor ingresado fue: {mayor}");
    }
}