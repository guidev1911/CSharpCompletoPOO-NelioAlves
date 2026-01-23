using System;

int x = 8;
int y = 10;

Console.WriteLine("=== Operadores Comparativos ===");

Console.WriteLine($"x == y  -> {x == y}");
Console.WriteLine($"x != y  -> {x != y}");
Console.WriteLine($"x > y   -> {x > y}");
Console.WriteLine($"x < y   -> {x < y}");
Console.WriteLine($"x >= y  -> {x >= y}");
Console.WriteLine($"x <= y  -> {x <= y}");

if (x < y)
{
    Console.WriteLine("x é menor que y");
}
