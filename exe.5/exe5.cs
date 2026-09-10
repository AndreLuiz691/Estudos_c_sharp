using System;

class aray
{
    static void Main()
    {
        int[] numero = new int [5];
        Console.WriteLine("seja bem vindo");
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"digite o{i+1} ");

            numero[i] = int.Parse(Console.ReadLine());
        }
          Console.WriteLine("fim");
    }
}