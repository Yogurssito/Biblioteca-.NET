class Program
{
    static void Main()
    {
        Console.Write("ingrese el largo de la caja: ");
        double largo = double.Parse(Console.ReadLine());
        Console.Write("ingrese el ancho de la caja: ");
        double ancho = double.Parse(Console.ReadLine());
        Console.Write("ingrese el alto de la caja: ");
        double alto = double.Parse(Console.ReadLine());
        double volumen = largo * ancho * alto;
        Console.WriteLine($"El volumen de la caja es: {volumen}");
    }
}