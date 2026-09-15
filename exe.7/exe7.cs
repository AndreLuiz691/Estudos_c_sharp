using System;
using System.Globalization;

class Caixa
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
        string nomeProduto = "";

        // Correção: usando '||' (ou) e removendo o ponto e vírgula incorreto
        while (opcao < 1 || opcao > 3)
        {
            Console.Write("\nDigite o número do produto desejado (1, 2 ou 3): ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        nomeProduto = "Cachorro Quente";
                        preco = 4.00;
                        break;

                    case 2:
                        nomeProduto = "X-Salada";
                        preco = 4.50;
                        break;
                    
                    case 3:
                        nomeProduto = "Refrigerante"; // Corrigido o typo "Refigerante"
                        preco = 1.50;
                        break;
                    
                    default:
                        Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Digite um número válido!");
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