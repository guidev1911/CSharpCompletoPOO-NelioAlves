using System;

class Program
{
    static void Main()
    {
        int idade = 18;

        // IF normal
        string resultado1;

        if (idade >= 18)
        {
            resultado1 = "Maior de idade";
        }
        else
        {
            resultado1 = "Menor de idade";
        }

        Console.WriteLine(resultado1);

        // EXPRESSÃO TERNÁRIA
        string resultado2 = idade >= 18 
            ? "Maior de idade"
            : "Menor de idade";

        Console.WriteLine(resultado2);
    }
}