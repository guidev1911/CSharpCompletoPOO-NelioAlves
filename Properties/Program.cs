class Pessoa
{
    private string nome;

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Nome inválido.");
                return;
            }

            nome = value;
        }
    }
}
