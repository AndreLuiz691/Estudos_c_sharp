using System;

class frdd
{
    static void Main()
    {
        Console.WriteLine("Seja BEm vindo!");

        Console.WriteLine("Digite um numero: ");

        int numero4 = int.Parse(Console.ReadLine());

        for (int i = numero4 ; i <= 10; i++)
        {
            Console.WriteLine("contador:"+i);
        }
 
    }
}