using System;

class Contador
{
    static void Main() 
    {
    Console.WriteLine("Seja Bem Vindo");

    Console.WriteLine("Digite um numero de 1 a 100: ");

    int numero3 = int.Parse(Console.ReadLine());

    while (numero3 <= 100)
        {
            Console.WriteLine("Contador: "+ numero3);
            numero3++;
        }
}
}