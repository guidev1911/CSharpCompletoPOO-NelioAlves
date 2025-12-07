using System;
using System.Globalization;

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

Console.WriteLine("=== CultureInfo.InvariantCulture ===");

double numero = 1234.56;
DateTime data = DateTime.Now;

Console.WriteLine("Padrão da máquina: " + numero);
Console.WriteLine("InvariantCulture: " + numero.ToString(CultureInfo.InvariantCulture));

Console.WriteLine("Data (Invariant): " + data.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

string textoNumero = "78.99";
double convertido = double.Parse(textoNumero, CultureInfo.InvariantCulture);
Console.WriteLine("Parse com Invariant: " + convertido);

Console.WriteLine("\nFim!");
