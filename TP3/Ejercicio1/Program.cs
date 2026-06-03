class Program
{
    static void Main()
    {
        Console.WriteLine("=== Menu de Conversiones ===");
        Console.WriteLine("1 - Centimetros a Pulgadas");
        Console.WriteLine("2 - Kilometros a Millas");
        Console.WriteLine("3 - Kilogramos a Libras");
        Console.WriteLine("4 - Celsius a Fahrenheit");
        Console.Write("seleccione una opcion (1-4): ");
        int opcion = int.Parse(Console.ReadLine()!);

        Console.Write("ingrese el valor a convertir: ");
        double valor = double.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                double pulgadas = valor / 2.54;
                Console.WriteLine($"{valor} cm = {pulgadas} pulgadas");
                break;
            case 2:
                double millas = valor * 0.621371;
                Console.WriteLine($"{valor} km = {millas} millas");
                break;
            case 3:
                double libras = valor * 2.2046;
                Console.WriteLine($"{valor} kg = {libras} libras");
                break;
            case 4:
                double fahrenheit = (valor * 1.8) + 32;
                Console.WriteLine($"{valor} C = {fahrenheit} F");
                break;
            default:
                Console.WriteLine("opcion no valida.");
                break;
        }
    }
}