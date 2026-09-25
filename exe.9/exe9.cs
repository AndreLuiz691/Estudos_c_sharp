using System;
using System.Numerics;

class array
{
    static void main ()
    {
        int alunostotal = 3;

        int provastotal = 3;

        string[] alunos = new string[alunostotal];

        double[,] notas = new string[alunostotal, provastotal];

        Console.WriteLine("=== Cadastro de Alunos e Notas ===");

        for (int i = 0; i < alunostotal; i++);

        Console.Write($"Digite o nome do {i + 1}º aluno: ");

        alunos[1] = Console.ReadLine();

        for(int j = 0; j < totalprovas; j++)
        {

        Console.WriteLine($" -> Digite a nota da PRova {j + 1} do(a) {alunos[1]}: ");
        
        notas[i, j] = double.Parse(Console.ReadLine());

        }

        Console.WriteLine();

        


    }
}