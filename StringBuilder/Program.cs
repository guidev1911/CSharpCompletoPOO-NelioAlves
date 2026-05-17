using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Olá ");
        sb.Append("Mundo");

        Console.WriteLine(sb.ToString());

        sb.AppendLine();
        sb.AppendLine("C#");

        Console.WriteLine(sb.ToString());

        sb.Replace("Mundo", "Dev");

        Console.WriteLine(sb.ToString());
    }
}