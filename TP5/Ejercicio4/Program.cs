class Program
{
    static void Main()
    {
        Console.WriteLine("numeros del 1 al 100 que son pares Y multiplos de 7:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 7 == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}