using System;

int a = 10;
int b = 10;
int c = 10;
int d = 10;
int e = 10;

Console.WriteLine("=== Operadores de Atribuição ===");

a += 5;
Console.WriteLine($"a += 5  -> {a}");

b -= 3;
Console.WriteLine($"b -= 3  -> {b}");

c *= 2;
Console.WriteLine($"c *= 2  -> {c}");

d /= 2;
Console.WriteLine($"d /= 2  -> {d}");

e %= 4;
Console.WriteLine($"e %= 4  -> {e}");

string nome = null;
nome ??= "Usuário padrão";
Console.WriteLine($"\nnome ??= \"Usuário padrão\" -> {nome}");
