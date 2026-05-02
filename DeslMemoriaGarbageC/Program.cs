using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void CriarPessoa()
    {
        Pessoa p = new Pessoa();
        p.Nome = "João";

        Console.WriteLine("Dentro do método");
    }

    static void Main()
    {
        CriarPessoa();

        Console.WriteLine("Fim do programa");
    }
}