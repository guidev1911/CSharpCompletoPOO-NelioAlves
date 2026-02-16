using System;

class Base
{
    public string Publico = "Public";
    private string Privado = "Private";
    protected string Protegido = "Protected";
    internal string Interno = "Internal";
    protected internal string ProtInternal = "Protected Internal";
    private protected string PrivProt = "Private Protected";

    public void MostrarDentroDaClasse()
    {
        Console.WriteLine(Publico);
        Console.WriteLine(Privado);
        Console.WriteLine(Protegido);
        Console.WriteLine(Interno);
        Console.WriteLine(ProtInternal);
        Console.WriteLine(PrivProt);
    }
}

class Derivada : Base
{
    public void MostrarNaFilha()
    {
        Console.WriteLine(Publico);      // ✅
        // Console.WriteLine(Privado);   // ❌
        Console.WriteLine(Protegido);    // ✅
        Console.WriteLine(Interno);      // ✅ (mesmo projeto)
        Console.WriteLine(ProtInternal); // ✅
        Console.WriteLine(PrivProt);     // ✅ (mesmo projeto + herança)
    }
}

class Program
{
    static void Main()
    {
        Base obj = new Base();

        Console.WriteLine(obj.Publico);      // ✅
        // Console.WriteLine(obj.Privado);   // ❌
        // Console.WriteLine(obj.Protegido); // ❌
        Console.WriteLine(obj.Interno);      // ✅ (mesmo projeto)
        Console.WriteLine(obj.ProtInternal); // ✅
        // Console.WriteLine(obj.PrivProt);  // ❌
    }
}
