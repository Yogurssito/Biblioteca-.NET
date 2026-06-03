class Program
{
    static void Main()
    {
        Console.Write("ingrese la cantidad en pesos argentinos: ");
        double pesos = double.Parse(Console.ReadLine());
        Console.Write("ingrese el tipo de cambio (pesos por dolar): ");
        double tipoCambio = double.Parse(Console.ReadLine());
        double dolares = pesos / tipoCambio;
        Console.WriteLine($"{pesos} pesos equivalen a {dolares} dolares");
    }
}