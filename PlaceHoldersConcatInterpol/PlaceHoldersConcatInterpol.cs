using System;

string nome = "Guilherme";
int idade = 25;
double altura = 1.82;

Console.WriteLine("=== Exemplos de Saída ===\n");


Console.WriteLine("Placeholders:");
Console.WriteLine("Nome: {0}, Idade: {1}, Altura: {2}m", nome, idade, altura);

Console.WriteLine("\nInterpolação:");
Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}m");

Console.WriteLine("\nConcatenação:");
Console.WriteLine("Nome: " + nome + ", Idade: " + idade + ", Altura: " + altura + "m");
