class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("ingrese un numero entero positivo (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()!);

            if (numero != 0)
            {
                int sumaDigitos = 0;
                string numStr = Math.Abs(numero).ToString();
                foreach (char c in numStr)
                    sumaDigitos += (int)char.GetNumericValue(c);
                Console.WriteLine($"suma de los digitos de {numero}: {sumaDigitos}");
            }
        }
        while (numero != 0);

        Console.WriteLine("Programa finalizado.");
    }
}