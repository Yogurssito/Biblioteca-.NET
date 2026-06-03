class Program
{
    static void Main()
    {
        Console.Write("Ingrese la base del triangulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del triangulo: ");
        double altura = double.Parse(Console.ReadLine());
        double area = (baseT * altura) / 2;
        Console.WriteLine($"El area del triangulo es: {area}");
    }
}