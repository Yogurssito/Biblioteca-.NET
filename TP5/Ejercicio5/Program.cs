class Program
{
    static void Main()
    {
        int positivos = 0;

        Console.Write("ingrese un numero entero (0 para terminar): ");
        int numero = int.Parse(Console.ReadLine()!);

        while (numero != 0)
        {
            if (numero > 0)
                positivos++;

            Console.Write("ingrese un numero entero (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"cantidad de numeros positivos ingresados: {positivos}");
    }
}