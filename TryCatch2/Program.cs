using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Abrindo arquivo...");

            int x = 10;
            int y = 0;

            Console.WriteLine(x / y);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: divisão por zero.");
        }
        finally
        {
            Console.WriteLine("Fechando arquivo...");
        }
    }
}