using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois números separados por espaço:");
        string[] valores = Console.ReadLine().Split(' ');

        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);

        Console.WriteLine($"Você digitou: {a} e {b}");

        Console.WriteLine("Digite alguns nomes separados por espaço:");
        string[] nomes = Console.ReadLine().Split(' ');

        foreach (string nome in nomes)
        {
            Console.WriteLine($"Nome: {nome}");
        }

        Console.WriteLine("Digite nome, idade e altura:");
        string[] dados = Console.ReadLine().Split(' ');

        string nomePessoa = dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2]);

        Console.WriteLine($"Nome: {nomePessoa}, Idade: {idade}, Altura: {altura}");
    }
}