using System;

class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    // 1️⃣ Construtor principal
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        if (saldoInicial < 0)
            throw new ArgumentException("Saldo inicial não pode ser negativo");

        Titular = titular;
        Saldo = saldoInicial;
    }

    // 2️⃣ SOBRECARGA: começa com saldo zero
    public ContaBancaria(string titular)
        : this(titular, 0) // chama o construtor principal
    {
    }

    // 3️⃣ SOBRECARGA: conta "padrão"
    public ContaBancaria()
        : this("Titular não informado", 0)
    {
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
        Console.WriteLine("-----------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sobrecarga de construtores ===\n");

        ContaBancaria conta1 = new ContaBancaria("Guilherme", 1000);
        ContaBancaria conta2 = new ContaBancaria("Maria");
        ContaBancaria conta3 = new ContaBancaria();

        conta1.MostrarDados();
        conta2.MostrarDados();
        conta3.MostrarDados();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
