using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("ingrese el texto a convertir a Morse: ");
        string texto = Console.ReadLine();
        ConvertirAMorse(texto);
    }

    static void ConvertirAMorse(string texto)
    {
        Dictionary<char, string> morse = new Dictionary<char, string>
        {
            {'A', ".-"},   {'B', "-..."},  {'C', "-.-."},  {'D', "-.."},
            {'E', "."},    {'F', "..-."},  {'G', "--."},   {'H', "...."},
            {'I', ".."},   {'J', ".---"},  {'K', "-.-"},   {'L', ".-.."},
            {'M', "--"},   {'N', "-."},    {'O', "---"},   {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."},   {'S', "..."},   {'T', "-"},
            {'U', "..-"},  {'V', "...-"},  {'W', ".--"},   {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."},
            {'0', "-----"},{'1', ".----"}, {'2', "..---"},
            {'3', "...--"},{'4', "....-"}, {'5', "....."},
            {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----."}
        };

        string resultado = "";
        foreach (char c in texto.ToUpper())
        {
            if (c == ' ')
                resultado += "/";
            else if (morse.ContainsKey(c))
                resultado += morse[c] + " ";
        }

        Console.WriteLine($"codigo morse: {resultado.Trim()}");
    }
}