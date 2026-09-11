using System;

class caixa
{
    static void Main()
    {
        Console.WriteLine("Seja Bem Vindo"); 

        Console.WriteLine("=== BEM-VINDO À LOJA ===");
        Console.WriteLine("1 - Cachorro Quente (R$ 4.00)");
        Console.WriteLine("2 - X-Salada (R$ 4.50)");
        Console.WriteLine("3 - Refrigerante (R$ 1.50)");
        Console.WriteLine("=======================");

        int opcao = 0;
        double preco = 0.0;
        string nomeproduto = "";

        while (opcao < 1 / opcao >3 )
        {
            Console.Write("\nDigite o número do produto desejado (1, 2 ou 3): ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                    nomeproduto = "Cachorro Quente";
                    preco = 4.00;
                    break;

                    case 2:
                    nomeproduto = "X-Salada";
                    preco = 4.50;
                    break;
                    
                    case 3:
                    nomeproduto = "Refigerante";
                    preco = 1.50;
                    break;
                }
            }
            else
            {
                Console.WriteLine("digite um numero valido");
            }
        }
        Console.Write($"Digite a quantidade de '{nomeProduto}': ");
        int quantidade = int.Parse(Console.ReadLine());

        double total = quantidade * preco;

        Console.WriteLine("\n--- RESUMO DO PEDIDO ---");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Total a pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}