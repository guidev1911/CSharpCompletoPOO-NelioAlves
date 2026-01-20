using System;

Console.WriteLine("=== Conversões em C# ===");

// Conversão implícita
int a = 10;
double b = a;
Console.WriteLine($"Implícita: int -> double : {b}");

// Casting explícito
double x = 9.7;
int y = (int)x;
Console.WriteLine($"Casting explícito: double -> int : {y}");

// Conversão que pode perder dados
long grande = 3000000000;
int pequeno = (int)grande;
Console.WriteLine($"Possível perda de dados: long -> int : {pequeno}");

// Convert
string texto = "123";
int numeroConvertido = Convert.ToInt32(texto);
Console.WriteLine($"Convert.ToInt32: \"123\" -> {numeroConvertido}");
