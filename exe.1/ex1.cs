using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Seja Bem Vindo");

        Console.WriteLine("Digite o primerio numero: ");

        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um segundo numero: ");

        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Soma = " + (numero1+numero2));
        Console.WriteLine("Subtração = " + (numero1-numero2));
        Console.WriteLine("Divisão = " + (numero1/numero2));
        Console.WriteLine("multiplicação = " + (numero1*numero2));
    }
}