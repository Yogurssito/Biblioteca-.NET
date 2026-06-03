class Program
{
    static void Main()
    {
        Console.Write("ingrese la edad de la persona: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 0 && edad <= 12)
            Console.WriteLine("La persona es un niño (0 a 12 anos)");
        else if (edad >= 13 && edad <= 17)
            Console.WriteLine("La persona es un adolecente (13 a 17 anos)");
        else if (edad >= 18 && edad <= 64)
            Console.WriteLine("La persona es un adulto (18 a 64 anos)");
        else if (edad > 64)
            Console.WriteLine("La persona es una persona mayor (65 anos o mas)");
        else
            Console.WriteLine("Edad invalida.");
    }
}