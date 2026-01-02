using System;

class Program
{
    static void Main()
    {
        int[] notas = { 6, 8, 4, 9, 7 };

        int soma = 0;
        int acimaDaMedia = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        double media = (double)soma / notas.Length;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= media)
            {
                acimaDaMedia++;
            }
        }

        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Notas acima da média: {acimaDaMedia}");
    }
}
