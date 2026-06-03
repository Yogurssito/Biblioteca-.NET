class Program
{
    static void Main()
    {
        int vocales = 0;
        int noVocales = 0;
        string listaVocales = "aeiou AEIOU";

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"ingrese el caracter {i + 1}: ");
            char c = Console.ReadLine()![0];

            if (listaVocales.Contains(c))
                vocales++;
            else
                noVocales++;
        }

        Console.WriteLine($"Cantidad de vocales: {vocales}");
        Console.WriteLine($"Cantidad de no vocales: {noVocales}");
    }
}