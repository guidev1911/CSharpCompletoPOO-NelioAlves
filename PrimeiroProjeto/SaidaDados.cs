using System;

Console.WriteLine("=== Exemplos de Saída de Dados ===");

Console.Write("Write sem quebra… ");
Console.WriteLine("WriteLine com quebra!");

string nome = "Guilherme";
int idade = 30;
double preco = 199.99;

Console.WriteLine($"\nInterpolação: Nome = {nome}, Idade = {idade}");
Console.WriteLine("Concatenação: Nome = " + nome + ", Idade = " + idade);
Console.WriteLine("Placeholders: Nome = {0}, Idade = {1}", nome, idade);

Console.WriteLine($"\nPreço formatado (2 decimais): {preco:F2}");
Console.WriteLine($"Preço como moeda: {preco:C}");
Console.WriteLine($"Preço com milhar: {preco:N}");

Console.WriteLine("\nQuebras de linha e tabulação:");
Console.WriteLine("Item 1\nItem 2\nItem 3");
Console.WriteLine("Coluna A\tColuna B");

Console.WriteLine("\nCaracteres especiais:");
Console.WriteLine("Aspas: \"texto\"");
Console.WriteLine("Barra invertida: \\");

DateTime agora = DateTime.Now;
Console.WriteLine($"\nData atual: {agora:dd/MM/yyyy HH:mm:ss}");

Console.WriteLine("\nFim!");
