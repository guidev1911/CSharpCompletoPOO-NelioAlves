using System;

Console.WriteLine("=== Tipos de Dados Básicos em C# ===");

int idade = 25;
long populacaoMundial = 8000000000;

float temperatura = 26.5f;   
double preco = 199.99;       
decimal salario = 3500.75m;  

char inicial = 'G';
string nome = "Guilherme";

SByte x = 100;

bool ativo = true;

Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"População mundial: {populacaoMundial}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Preço: {preco}");
Console.WriteLine($"Salário: {salario}");
Console.WriteLine($"Inicial do nome: {inicial}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Ativo: {ativo}");

Console.WriteLine("\nPrograma finalizado!");
