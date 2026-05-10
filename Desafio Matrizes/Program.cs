using System;

class Program
{
    static void Main()
    {
        string[] tamanhos = Console.ReadLine().Split(' ');

        int m = int.Parse(tamanhos[0]);
        int n = int.Parse(tamanhos[1]);

        int[,] mat = new int[m, n];

        // leitura da matriz
        for (int i = 0; i < m; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(valores[j]);
            }
        }

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] == x)
                {
                    Console.WriteLine($"Posição {i},{j}:");

                    // esquerda
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                    }

                    // acima
                    if (i > 0)
                    {
                        Console.WriteLine("Acima: " + mat[i - 1, j]);
                    }

                    // direita
                    if (j < n - 1)
                    {
                        Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }

                    // abaixo
                    if (i < m - 1)
                    {
                        Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}