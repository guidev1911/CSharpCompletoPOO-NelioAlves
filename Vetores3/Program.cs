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
            produtos[i] = new Produto();

            Console.WriteLine($"Produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
        }

        // média
        double soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += produtos[i].Preco;
        }
        double media = soma / n;

        // mais caro
        Produto maisCaro = produtos[0];
        for (int i = 1; i < n; i++)
        {
            if (produtos[i].Preco > maisCaro.Preco)
            {
                maisCaro = produtos[i];
            }
        }

        // acima da média
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (produtos[i].Preco > media)
            {
                count++;
            }
        }

        Console.WriteLine($"\nMédia: {media}");
        Console.WriteLine($"Mais caro: {maisCaro.Nome} - {maisCaro.Preco}");
        Console.WriteLine($"Acima da média: {count}");
    }
}