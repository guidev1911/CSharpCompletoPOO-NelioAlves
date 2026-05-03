using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0;

        for (int i = 0; i < 3; i++)
        {
            soma += numeros[i];
        }

        double media = soma / 3;

        Console.WriteLine($"Média: {media}");
    }
}