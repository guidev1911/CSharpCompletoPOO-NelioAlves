using System;

class Program
{
    static void Main()
    {
        string texto = "  Olá Mundo  ";

        // ToUpper / ToLower
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());

        // Trim
        Console.WriteLine(texto.Trim());

        // Split
        string[] partes = texto.Split(' ');
        
        // Substring
        Console.WriteLine(texto.Substring(2, 4));

        // Replace
        Console.WriteLine(texto.Replace("Mundo", "C#"));

        // Contains
        Console.WriteLine(texto.Contains("Olá"));

        // StartsWith / EndsWith
        Console.WriteLine(texto.StartsWith(" "));
        Console.WriteLine(texto.EndsWith(" "));

        // IndexOf / LastIndexOf
        Console.WriteLine(texto.IndexOf("M"));
        Console.WriteLine(texto.LastIndexOf("o"));

        // IsNullOrEmpty
        Console.WriteLine(string.IsNullOrEmpty(texto));

        // Length
        Console.WriteLine(texto.Length);
    }
}