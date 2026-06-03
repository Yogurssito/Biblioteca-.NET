class Program
{
    static void Main()
    {
        Console.WriteLine("numeros pares entre 1 y 50:");
        for (int i = 2; i <= 50; i += 2)
            Console.Write($"{i} ");
        Console.WriteLine();
    }
}