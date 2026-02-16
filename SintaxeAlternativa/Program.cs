using System;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto
        {
            Nome = "Teclado",
            Preco = 199.90m
        };

        Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
    }
}
