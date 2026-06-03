class Program
{
    static void Main()
    {
        Console.Write("ingrese el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"el perimetro del circulo es: {perimetro}");
    }
}