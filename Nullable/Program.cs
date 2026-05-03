using System;

class Program
{
    static void Main()
    {
        int? a = null;
        int b = a ?? 10;

        int? c = 5;
        int d = c ?? 10;

        Console.WriteLine(b);
        Console.WriteLine(d);
    }
}