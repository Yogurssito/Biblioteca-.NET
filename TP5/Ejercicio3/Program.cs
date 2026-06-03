class Program
{
    static void Main()
    {
        Console.WriteLine("numeros del 100 al 0 (de 5 en 5):");
        for (int i = 100; i >= 0; i -= 5)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}