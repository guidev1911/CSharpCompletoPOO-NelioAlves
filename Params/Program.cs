using System;

class Program
{
    static int Somar(params int[] numeros)
    {
        int soma = 0;
        foreach (int n in numeros)
        {
            soma += n;
        }
        return soma;
    }

    static void Main()
    {
        Console.WriteLine(Somar(1, 2, 3));    
        Console.WriteLine(Somar(10, 20));      
    }
}