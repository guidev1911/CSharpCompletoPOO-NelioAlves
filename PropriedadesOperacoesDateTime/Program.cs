using System;

class Program
{
    static void Main()
    {
        DateTime agora = DateTime.Now;

        // PROPRIEDADES
        Console.WriteLine("Dia: " + agora.Day);
        Console.WriteLine("Mês: " + agora.Month);
        Console.WriteLine("Ano: " + agora.Year);

        Console.WriteLine("Hora: " + agora.Hour);
        Console.WriteLine("Minuto: " + agora.Minute);
        Console.WriteLine("Segundo: " + agora.Second);

        Console.WriteLine("Dia da semana: " + agora.DayOfWeek);
        Console.WriteLine("Dia do ano: " + agora.DayOfYear);

        // OPERAÇÕES
        Console.WriteLine("\n+7 dias:");
        Console.WriteLine(agora.AddDays(7));

        Console.WriteLine("\n+2 meses:");
        Console.WriteLine(agora.AddMonths(2));

        Console.WriteLine("\n-3 horas:");
        Console.WriteLine(agora.AddHours(-3));

        // diferença entre datas
        DateTime futuro = agora.AddDays(10);

        TimeSpan diferenca = futuro - agora;

        Console.WriteLine("\nDiferença em dias:");
        Console.WriteLine(diferenca.Days);
    }
}