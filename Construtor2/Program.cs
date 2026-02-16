using System;

class Personagem
{
    public string Nome { get; private set; }
    public int Vida { get; private set; }
    public int Forca { get; private set; }

    public Personagem(string nome, int vida, int forca)
    {
        if (vida <= 0)
            throw new ArgumentException("Vida deve ser maior que zero");

        Nome = nome;
        Vida = vida;
        Forca = forca;
    }

    public Personagem(string nome)
        : this(nome, 100, 10)   
    {
    }

    public void Atacar()
    {
        Console.WriteLine($"{Nome} atacou causando {Forca} de dano!");
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine("--------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Criando personagens ===\n");

        Personagem heroi = new Personagem("Herói", 150, 20);
        Personagem npc = new Personagem("NPC");

        heroi.MostrarStatus();
        npc.MostrarStatus();

        heroi.Atacar();
        npc.Atacar();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
