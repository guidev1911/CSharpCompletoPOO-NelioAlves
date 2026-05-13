using System;

class Program
{
    static void Main()
    {
        int numero = 2;

        // SWITCH NORMAL
        switch (numero)
        {
            case 1:
                Console.WriteLine("Um");
                break;

            case 2:
                Console.WriteLine("Dois");
                break;

            case 3:
                Console.WriteLine("Três");
                break;

            default:
                Console.WriteLine("Outro número");
                break;
        }

        // SWITCH EXPRESSION
        string resultado = numero switch
        {
            1 => "Um",
            2 => "Dois",
            3 => "Três",
            _ => "Outro número"
        };

        Console.WriteLine(resultado);
    }
}