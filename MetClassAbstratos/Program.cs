using System;

abstract class Forma
{
    public abstract double Area();
}

class Retangulo : Forma
{
    public double Largura;
    public double Altura;

    public override double Area()
    {
        return Largura * Altura;
    }
}

class Circulo : Forma
{
    public double Raio;

    public override double Area()
    {
        return 3.14 * Raio * Raio;
    }
}

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo();
        r.Largura = 5;
        r.Altura = 4;

        Circulo c = new Circulo();
        c.Raio = 3;

        Console.WriteLine(r.Area());
        Console.WriteLine(c.Area());
    }
}