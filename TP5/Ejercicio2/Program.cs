class Program
{
    static void Main()
    {
        Console.Write("ingrese el valor de N: ");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;

        for (int i = 1; i <= n; i++)
            suma += i;

        Console.WriteLine($"la suma de todos los numeros desde 1 hasta {n} es: {suma}");
    }
}