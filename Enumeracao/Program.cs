using System;

enum StatusPedido
{
    Pendente,
    Processando,
    Enviado,
    Entregue
}

class Program
{
    static void Main()
    {
        StatusPedido pedido = StatusPedido.Processando;

        Console.WriteLine("Status do pedido:");
        Console.WriteLine(pedido);

        // valor numérico do enum
        Console.WriteLine("\nCódigo:");
        Console.WriteLine((int)pedido);

        // convertendo número para enum
        StatusPedido pedido2 = (StatusPedido)3;

        Console.WriteLine("\nOutro status:");
        Console.WriteLine(pedido2);
    }
}