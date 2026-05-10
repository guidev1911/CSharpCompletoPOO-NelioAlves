using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        nomes.Add("Ana");
        nomes.Add("Carlos");
        nomes.Add("Maria");

        nomes.Insert(1, "João");

        Console.WriteLine("Quantidade: " + nomes.Count);

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        nomes.Remove("Carlos");

        Console.WriteLine("\nDepois do Remove:");

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}