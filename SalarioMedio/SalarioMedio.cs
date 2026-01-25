using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do primeiro funcionário: ");
        string nome1 = Console.ReadLine();

        Console.Write("Digite o salário do primeiro funcionário: ");
        double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.Write("Digite o nome do segundo funcionário: ");
        string nome2 = Console.ReadLine();

        Console.Write("Digite o salário do segundo funcionário: ");
        double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (salario1 + salario2) / 2.0;

        Console.WriteLine();
        Console.WriteLine("=== Resultado ===");
        Console.WriteLine($"Funcionário 1: {nome1} - Salário: {salario1.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Funcionário 2: {nome2} - Salário: {salario2.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Média salarial: {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
