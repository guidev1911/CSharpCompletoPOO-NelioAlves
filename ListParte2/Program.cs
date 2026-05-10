using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>()
        {
            "Ana",
            "Carlos",
            "Maria",
            "Marcos",
            "Amanda"
        };

        string primeiroM = nomes.Find(x => x[0] == 'M');

        Console.WriteLine("Primeiro com M: " + primeiroM);

        List<string> listaM = nomes.FindAll(x => x[0] == 'M');

        Console.WriteLine("\nNomes com M:");

        foreach (string nome in listaM)
        {
            Console.WriteLine(nome);
        }

        nomes.RemoveAll(x => x.Length > 5);

        Console.WriteLine("\nDepois do RemoveAll:");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}