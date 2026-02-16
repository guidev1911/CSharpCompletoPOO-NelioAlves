using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();

        p.Nome = "Guilherme"; // set
        p.Idade = 25;         // set

        Console.WriteLine($"Nome: {p.Nome}");   // get
        Console.WriteLine($"Idade: {p.Idade}"); // get
    }
}
