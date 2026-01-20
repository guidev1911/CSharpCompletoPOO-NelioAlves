using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void VerificarMaiorIdade()
    {
        if (Idade >= 18)
            Console.WriteLine($"{Nome} é maior de idade");
        else
            Console.WriteLine($"{Nome} é menor de idade");
    }
}

class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Guilherme";
        p1.Idade = 17;

        Pessoa p2 = new Pessoa();
        p2.Nome = "Ana";
        p2.Idade = 22;

        p1.VerificarMaiorIdade();
        p2.VerificarMaiorIdade();
    }
}
