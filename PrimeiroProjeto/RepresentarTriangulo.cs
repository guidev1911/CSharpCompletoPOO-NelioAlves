using System;

class Triangulo
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
}

class Program
{
    static void Main()
    {
        Triangulo x = new Triangulo();
        x.A = 3;
        x.B = 4;
        x.C = 5;

        Triangulo y = new Triangulo();
        y.A = 6;
        y.B = 8;
        y.C = 10;

        Console.WriteLine("Triângulo X:");
        Console.WriteLine($"A = {x.A}, B = {x.B}, C = {x.C}");

        Console.WriteLine("\nTriângulo Y:");
        Console.WriteLine($"A = {y.A}, B = {y.B}, C = {y.C}");
    }
}
