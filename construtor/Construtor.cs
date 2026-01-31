using System;

class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    // Construtor
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        if (saldoInicial < 0)
            throw new ArgumentException("Saldo inicial não pode ser negativo");

        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido para depósito.");
            return;
        }

        Saldo += valor;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Criando conta bancária ===");

        ContaBancaria conta = new ContaBancaria("Guilherme", 1000);

        conta.MostrarDados();

        Console.WriteLine("\nDepositando R$ 500...");
        conta.Depositar(500);

        Console.WriteLine("\nDados atualizados:");
        conta.MostrarDados();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
