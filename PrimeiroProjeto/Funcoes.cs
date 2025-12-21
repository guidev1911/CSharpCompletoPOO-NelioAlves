using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int b = int.Parse(Console.ReadLine());

        int soma = Somar(a, b);
        Console.WriteLine($"Soma = {soma}");

        Console.WriteLine(VerificarPar(soma));
    }

    static int Somar(int x, int y)
    {
        return x + y;
    }

    static string VerificarPar(int numero)
    {
        if (numero % 2 == 0)
            return "O número é par";
        else
            return "O número é ímpar";
    }
}
