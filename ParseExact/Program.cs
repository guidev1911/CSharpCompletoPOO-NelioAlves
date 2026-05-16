using System;

class Program
{
    static void Main()
    {
        // criando TimeSpan
        TimeSpan t1 = new TimeSpan(2, 30, 10);

        Console.WriteLine(t1);

        // horas, minutos, segundos
        Console.WriteLine("Horas: " + t1.Hours);
        Console.WriteLine("Minutos: " + t1.Minutes);
        Console.WriteLine("Segundos: " + t1.Seconds);

        // total
        Console.WriteLine("Total minutos: " + t1.TotalMinutes);

        // somando tempo
        TimeSpan t2 = new TimeSpan(1, 0, 0);

        TimeSpan soma = t1.Add(t2);

        Console.WriteLine("Soma: " + soma);

        // diferença entre datas
        DateTime inicio = new DateTime(2026, 5, 1);
        DateTime fim = new DateTime(2026, 5, 10);

        TimeSpan diferenca = fim - inicio;

        Console.WriteLine("Dias de diferença: " + diferenca.Days);
    }
}