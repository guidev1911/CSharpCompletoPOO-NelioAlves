using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome da primeira pessoa: ");
        string nome1 = Console.ReadLine();

        Console.Write("Digite a idade da primeira pessoa: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Digite o nome da segunda pessoa: ");
        string nome2 = Console.ReadLine();

        Console.Write("Digite a idade da segunda pessoa: ");
        int idade2 = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (idade1 > idade2)
        {
            Console.WriteLine($"A pessoa mais velha é {nome1}");
        }
        else if (idade2 > idade1)
        {
            Console.WriteLine($"A pessoa mais velha é {nome2}");
        }
        else
        {
            Console.WriteLine($"{nome1} e {nome2} têm a mesma idade");
        }
    }
}
1