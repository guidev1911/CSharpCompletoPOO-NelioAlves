using System;

class Funcionario
{
    public virtual double CalcularBonus()
    {
        return 1000;
    }
}

class Gerente : Funcionario
{
    public override double CalcularBonus()
    {
        return base.CalcularBonus() + 2000;
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario();
        Gerente g = new Gerente();

        Console.WriteLine(f.CalcularBonus());
        Console.WriteLine(g.CalcularBonus());
    }
}