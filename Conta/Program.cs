using System;

class Program
{
    static void Main()
    {
        ContaPoupanca contab = new ContaPoupanca();

        contab.Numero = 1;
        contab.Titular = "Guilherme";
        contab.Saldo = 1000;
        contab.Juros = 0.10;

        contab.Depositar(500);
        contab.AtualizarSaldo();

        Console.WriteLine(contab.Saldo);
    }
}