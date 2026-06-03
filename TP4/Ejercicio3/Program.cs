class Program
{
    static void Main()
    {
        int inicio, fin;

        do
        {
            Console.Write("ingrese el numero de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("ingrese el numero de fin: ");
            fin = int.Parse(Console.ReadLine());

            if (inicio >= fin)
                Console.WriteLine("el numero de inicio debe ser menor al de fin, intente de vuelta.");
        }
        while (inicio >= fin);

        Console.WriteLine($"numeros primos entre {inicio} y {fin}:");

        for (int n = inicio; n <= fin; n++)
        {
            if (EsPrimo(n))
                Console.Write($"{n} ");
        }
        Console.WriteLine();
    }

    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        int i = 2;
        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0) return false;
            i++;
        }
        return true;
    }
}