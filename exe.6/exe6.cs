using System;

class compr
{
    static void Main()
    {
        Console.WriteLine("Seja Bem Vindo");

        Console.WriteLine("Digite o Nome do item, seguido por sua quantidade e valor: ");

        string[] ind = Console.ReadLine().Split(' ');

        string NomeI = ind[0];
        int QuantI = int.Parse(ind[1]);
        double ValorI = double.Parse(ind[2]);

        double total = (QuantI * ValorI);

        Console.WriteLine("item: "+ NomeI);
        Console.WriteLine("total a pagar: "+ total);

    }
}