class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine()!;

        if (EsPalindromo(cadena))
            Console.WriteLine($"\"{cadena}\" ES un palindromo.");
        else
            Console.WriteLine($"\"{cadena}\" NO es un palindromo.");
    }

    static bool EsPalindromo(string cadena)
    {
        string limpia = cadena.ToLower().Replace(" ", "");
        int longitud = limpia.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (limpia[i] != limpia[longitud - 1 - i])
                return false;
        }
        return true;
    }
}