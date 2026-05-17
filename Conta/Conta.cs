class Contab
{
    public int Numero;
    public string Titular;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}