using System;

Console.WriteLine("=== Sistema de Acesso ===");

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Você tem autorização? (s/n): ");
string resposta = Console.ReadLine();

bool temAutorizacao = resposta == "s" || resposta == "S";

Console.WriteLine();

if (idade >= 18 || temAutorizacao)
{
    Console.WriteLine($"Acesso liberado, {nome}!");
}
else
{
    Console.WriteLine($"Acesso negado, {nome}.");
    Console.WriteLine("Motivo: menor de idade e sem autorização.");
}

Console.WriteLine("Fim do programa.");