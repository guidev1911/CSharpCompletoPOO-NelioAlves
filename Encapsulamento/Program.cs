using System;

class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular, decimal saldoInicial)
    {
        if (saldoInicial < 0)
            throw new ArgumentException("Saldo inicial inválido");

        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Depósito inválido");
            return;
        }

        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo)
        {
            Console.WriteLine("Saque inválido");
            return;
        }

        Saldo -= valor;
    }
}

class Program
{
    static void Main()
    {
        var conta = new ContaBancaria("Guilherme", 1000);

        conta.Depositar(500);
        conta.Sacar(200);

        Console.WriteLine($"Saldo final: R$ {conta.Saldo}");

        // conta.Saldo = -1000; ❌ não compila
    }
}
