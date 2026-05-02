using System;

namespace TiposValorReferencia
{
    class Pessoa
    {
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;

            Pessoa p1 = new Pessoa();
            p1.Nome = "Ana";

            Pessoa p2 = p1;
            p2.Nome = "Maria";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p2.Nome);
        }
    }
}