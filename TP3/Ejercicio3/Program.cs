class Program
{
    static void Main()
    {
        Console.Write("ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine()!);
        Console.Write("ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine()!);
        Console.Write("ingrese la operacion (+, -, *, /, %): ");
        string operacion = Console.ReadLine()!;

        switch (operacion)
        {
            case "+":
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case "/":
                if (num2 == 0)
                    Console.WriteLine("error: no se puede dividir por cero.");
                else
                    Console.WriteLine($"Resultado: {num1 / num2}");
                break;
            case "%":
                if (num2 == 0)
                    Console.WriteLine("error: no se puede calcular el modulo con divisor cero.");
                else
                    Console.WriteLine($"resultado: {num1 % num2}");
                break;
            default:
                Console.WriteLine("operacion no valida.");
                break;
        }
    }
}