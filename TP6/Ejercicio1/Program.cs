class Program
{
    static void Main()
    {
        Console.Write("ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.Write("ingrese el exponente: ");
        int exponente = int.Parse(Console.ReadLine());

        long resultado = CalcularPotencia(baseNum, exponente);
        Console.WriteLine($"{baseNum} elevado a {exponente} es: {resultado}");
    }

    static long CalcularPotencia(int baseNum, int exponente)
    {
        long resultado = 1;
        for (int i = 0; i < exponente; i++)
            resultado *= baseNum;
        return resultado;
    }
}