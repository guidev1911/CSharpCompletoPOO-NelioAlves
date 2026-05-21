using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(10 / x);
        }
        catch (FormatException)
        {
            Console.WriteLine("Você digitou um valor inválido.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não pode dividir por zero.");
        }
        finally
        {
            Console.WriteLine("Fim do programa.");
        }
    }
}