using System;

sealed class Animal
{
    public void FazerSom()
    {
        Console.WriteLine("Som");
    }
}

// ERRO
// class Cachorro : Animal
// {
// }

class Pessoa
{
    public virtual void Apresentar()
    {
        Console.WriteLine("Olá");
    }
}

class Cliente : Pessoa
{
    public sealed override void Apresentar()
    {
        Console.WriteLine("Cliente");
    }
}

// ERRO
// class ClienteVip : Cliente
// {
//     public override void Apresentar()
//     {
//     }
// }

class Program
{
    static void Main()
    {
        Cliente c = new Cliente();

        c.Apresentar();
    }
}