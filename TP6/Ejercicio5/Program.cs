class Program
{
    static void Main()
    {
        Console.Write("ingrese el valor a convertir: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione la conversion:");
        Console.WriteLine("1 - Kilometros a Millas");
        Console.WriteLine("2 - Celsius a Fahrenheit");
        Console.WriteLine("3 - Kilogramos a Libras");
        Console.Write("opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        string[] unidades = { "millas", "Fahrenheit", "libras" };

        if (opcion >= 1 && opcion <= 3)
        {
            double resultado = Convertir(valor, opcion);
            Console.WriteLine($"resultado: {resultado} {unidades[opcion - 1]}");
        }
        else
        {
            Console.WriteLine("opcion no valida.");
        }
    }

    static double Convertir(double valor, int opcion)
    {
        switch (opcion)
        {
            case 1: return valor * 0.621371;
            case 2: return (valor * 1.8) + 32;
            case 3: return valor * 2.2046;
            default: return 0;
        }
    }
}