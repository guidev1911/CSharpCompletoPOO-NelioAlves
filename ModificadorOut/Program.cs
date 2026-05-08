using System;

class Program
{
    static void GerarNumero(out int x)
    {
        x = 50;
    }

    static void Main()
    {
        int n;

        GerarNumero(out n);

        Console.WriteLine(n); // 50
    }
}