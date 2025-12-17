using System;

class Program
{
    static void Main()
    {
        int idade = 0; // inicializada no escopo do método

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            string status = "Maior de idade"; // escopo do if
            Console.WriteLine(status);
        }
        else
        {
            string status = "Menor de idade"; // escopo do else
            Console.WriteLine(status);
        }

        // Console.WriteLine(status); ❌ ERRO: fora do escopo

        Console.WriteLine("Programa finalizado");
    }
}
