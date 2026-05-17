using System;
using System.Collections.Generic;

class Funcionario
{
    public virtual double CalcularPagamento()
    {
        return 2000;
    }
}

class Freelancer : Funcionario
{
    public override double CalcularPagamento()
    {
        return 3500;
    }
}

class Estagiario : Funcionario
{
    public override double CalcularPagamento()
    {
        return 1200;
    }
}

class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(new Funcionario());
        funcionarios.Add(new Freelancer());
        funcionarios.Add(new Estagiario());

        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine(f.CalcularPagamento());
        }
    }
}