class Program
{
    static void Main()
    {
        Console.WriteLine("Tipos de vehiculo: M = Motocicleta | A = Auto | C = Camion | O = Omnibus");
        Console.Write("ingrese el tipo de vehiculo: ");
        char tipo = Console.ReadLine()!.ToUpper()[0];

        switch (tipo)
        {
            case 'M':
                Console.WriteLine("Motocicleta - Costo del peaje: $800");
                break;
            case 'A':
                Console.WriteLine("Auto - Costo del peaje: $1.600");
                break;
            case 'C':
                Console.WriteLine("Camion - Costo del peaje: $4.200");
                break;
            case 'O':
                Console.WriteLine("Omnibus - Costo del peaje: $3.100");
                break;
            default:
                Console.WriteLine("Tipo de vehiculo no reconocido.");
                break;
        }
    }
}