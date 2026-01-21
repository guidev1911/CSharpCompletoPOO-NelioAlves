using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Entre com seu nome completo: ");
        string nomeCompleto = Console.ReadLine();

        Console.Write("Quantos quartos tem na sua casa? ");
        int quartos = int.Parse(Console.ReadLine());

        Console.Write("Entre com o preço de um produto: ");
        double preco = double.Parse(Console.ReadLine(), CI);

        Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
        string[] dados = Console.ReadLine().Split(' ');

        string ultimoNome = dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2], CI);

        Console.WriteLine();
        Console.WriteLine(nomeCompleto);
        Console.WriteLine(quartos);
        Console.WriteLine(preco.ToString("F2", CI));
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CI));
    }
}
