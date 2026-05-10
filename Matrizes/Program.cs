using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}