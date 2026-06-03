class Program
{
    static void Main()
    {
        int edad;
        do
        {
            Console.Write("ingrese su edad (1 a 120): ");
            edad = int.Parse(Console.ReadLine()!);

            if (edad < 1 || edad > 120)
                Console.WriteLine("edad invalida. Debe estar entre 1 y 120, intente de nuevo.");
        }
        while (edad < 1 || edad > 120);

        Console.WriteLine($"edad valida ingresada: {edad} anos");
    }
}