using System;

class Geometria
{
    public static double AreaTriangulo(double a, double b, double c)
    {
        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Triangulo
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public double Area()
    {
        return Geometria.AreaTriangulo(A, B, C);
    }
}

class Program
{
    static void Main()
    {
        Triangulo t1 = new Triangulo { A = 3, B = 4, C = 5 };
        Triangulo t2 = new Triangulo { A = 6, B = 8, C = 10 };

        Console.WriteLine($"Área t1: {t1.Area():F2}");
        Console.WriteLine($"Área t2: {t2.Area():F2}");
    }
}
