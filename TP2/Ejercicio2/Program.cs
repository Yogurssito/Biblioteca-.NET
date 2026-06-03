class Program
{
    static void Main()
    {
        Console.Write("ingrese un numero entero: ");
        int x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
            Console.WriteLine($"{x} es PAR");
        else
            Console.WriteLine($"{x} es IMPAR");
    }
}