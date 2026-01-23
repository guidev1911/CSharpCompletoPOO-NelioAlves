using System;

Console.WriteLine("=== Operadores Lógicos ===");

int idade = 17;
bool temRG = true;
bool temAutorizacao = false;

if ((idade >= 18 && temRG) || temAutorizacao)
{
    Console.WriteLine("Entrada permitida");
}
else
{
    Console.WriteLine("Entrada negada");
}

bool ativo = false;
Console.WriteLine($"Sistema ativo? {!ativo}");
