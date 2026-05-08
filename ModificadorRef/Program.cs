using System;

class Program
{
    static void Dobrar(ref int x)
    {
        x *= 2;
    }

    static void Main()
    {
        int n = 10;

        Dobrar(ref n);

        Console.WriteLine(n); 
    }
}