class Program
{
    static void Main()
    {
        int limite;
        do
        {
            Console.Write("ingrese un valor limite (debe ser positivo): ");
            limite = int.Parse(Console.ReadLine());
        }
        while (limite <= 0);

        int suma = 0;

        while (suma < limite)
        {
            Console.Write("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            suma += numero;
            Console.WriteLine($"Suma acumulada: {suma}");
        }

        Console.WriteLine($"la suma alcanzo o supero el limite. Suma final: {suma}");
    }
}