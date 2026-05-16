using System;

class Program
{
    static void Main()
    {
        // data atual
        DateTime agora = DateTime.Now;

        Console.WriteLine("Data atual:");
        Console.WriteLine(agora);

        // formatando
        Console.WriteLine("\nFormatada:");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));
        Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm:ss"));

        // pegando partes da data
        Console.WriteLine("\nPartes:");
        Console.WriteLine("Dia: " + agora.Day);
        Console.WriteLine("Mês: " + agora.Month);
        Console.WriteLine("Ano: " + agora.Year);
        Console.WriteLine("Hora: " + agora.Hour);

        // criando data específica
        DateTime aniversario = new DateTime(2000, 10, 5);

        Console.WriteLine("\nAniversário:");
        Console.WriteLine(aniversario.ToString("dd/MM/yyyy"));

        // adicionando tempo
        Console.WriteLine("\n+7 dias:");
        Console.WriteLine(agora.AddDays(7));

        Console.WriteLine("\n+2 horas:");
        Console.WriteLine(agora.AddHours(2));

        // diferença entre datas
        TimeSpan diferenca = agora - aniversario;

        Console.WriteLine("\nDias vividos:");
        Console.WriteLine(diferenca.Days);
    }
}