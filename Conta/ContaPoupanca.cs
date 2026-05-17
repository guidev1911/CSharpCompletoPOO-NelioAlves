class ContaPoupanca : Contab
{
    public double Juros;

    public void AtualizarSaldo()
    {
        Saldo += Saldo * Juros;
    }
}