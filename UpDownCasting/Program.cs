using System;

class Animal
{
    public void FazerSom()
    {
        Console.WriteLine("Som genérico");
    }
}

class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("Au au!");
    }
}

class Program
{
    static void Main()
    {
        // UPCASTING
        Animal a = new Cachorro();

        a.FazerSom();

        // a.Latir(); // erro

        // DOWNCASTING
        Cachorro c = (Cachorro)a;

        c.Latir();
    }
}