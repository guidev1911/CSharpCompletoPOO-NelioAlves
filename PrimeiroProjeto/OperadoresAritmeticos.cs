using System;

Console.WriteLine("=== Operadores Aritméticos ===");

int a = 10;
int b = 3;

Console.WriteLine($"Soma:        {a} + {b} = {a + b}");
Console.WriteLine($"Subtração:   {a} - {b} = {a - b}");
Console.WriteLine($"Multiplic.:  {a} * {b} = {a * b}");
Console.WriteLine($"Divisão:     {a} / {b} = {a / b}");
Console.WriteLine($"Módulo:      {a} % {b} = {a % b}");

int x = 5;
Console.WriteLine($"\nValor inicial de x: {x}");

Console.WriteLine($"x++  (pós):  {x++} -> depois: {x}");
x = 5;
Console.WriteLine($"++x  (pré):  {++x}");

x = 5;
Console.WriteLine($"x--  (pós):  {x--} -> depois: {x}");
x = 5;
Console.WriteLine($"--x  (pré):  {--x}");
