using System;

class Produto
{
    public string Nome;
    public double Preco;
}

class Program
{
    static void Main()
    {
        Console.Write("Quantos produtos? ");
        int n = int.Parse(Console.ReadLine());

        Produto[] produtos = new Produto[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Produto {i + 1}:");

            produtos[i] = new Produto();

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
        }

        double soma = 0;

        for (int i = 0; i < n; i++)
        {
            soma += produtos[i].Preco;
        }

        double media = soma / n;

        Console.WriteLine($"Média dos preços: {media}");
    }
}