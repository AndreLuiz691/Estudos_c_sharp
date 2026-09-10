using System;

class Notas
{
    static void Main()
    {
        Console.WriteLine("Seja Muito Bem Vindo!!!");

        Console.WriteLine("Digite sua Nota: ");

        double Nota = double.Parse(Console.ReadLine());

        if (Nota >= 7)
        {
            Console.WriteLine("Você foi aprovado");
        }
        else if (Nota == 6)
        {
            Console.WriteLine("Você esta de Recuperação!");
        }
        else
        {
            Console.WriteLine("Você esta de Recuperação!");
        }
    }
}