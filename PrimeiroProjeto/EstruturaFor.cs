using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas notas você vai digitar? ");
        int quantidade = int.Parse(Console.ReadLine());

        double soma = 0;
        double maior = double.MinValue;
        double menor = double.MaxValue;
        int aprovados = 0;

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            double nota = double.Parse(Console.ReadLine());

            soma += nota;

            if (nota > maior)
            {
                maior = nota;
            }

            if (nota < menor)
            {
                menor = nota;
            }

            if (nota >= 6)
            {
                aprovados++;
            }
        }

        double media = soma / quantidade;

        Console.WriteLine("\n=== Resultado ===");
        Console.WriteLine($"Média das notas: {media:F2}");
        Console.WriteLine($"Maior nota: {maior}");
        Console.WriteLine($"Menor nota: {menor}");
        Console.WriteLine($"Quantidade de aprovados: {aprovados}");
    }
}
