using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int numero = 0;

        while (numero >= 0)
        {
            Console.Write("Digite um número (negativo para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
                soma += numero;
        }

        Console.WriteLine($"Soma total: {soma}");
    }
}
