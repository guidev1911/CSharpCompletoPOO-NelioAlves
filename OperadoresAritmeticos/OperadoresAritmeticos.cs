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

Console.WriteLine("\n=== Funções Matemáticas ===");

double raiz = Math.Sqrt(25);         // raiz quadrada
double potencia = Math.Pow(4, 3);    // 4 elevado a 3 = 64

Console.WriteLine($"Math.Sqrt(25)  -> {raiz}");
Console.WriteLine($"Math.Pow(4, 3) -> {potencia}");

Console.WriteLine("\nFim!"); 