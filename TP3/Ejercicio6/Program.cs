class Program
{
    static void Main()
    {
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"ingrese el numero {i}: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine($"Numeros pares:   {pares}");
        Console.WriteLine($"Numeros impares: {impares}");
    }
}