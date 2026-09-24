using System;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez(); // // Cria uma nova partida de xadrez (que já vai inicializar o tabuleiro e as peças)

            Tela.ImprimirPartida(partida); // Usa a nossa classe Tela para imprimir a partida completa na tela

            Console.ReadLine(); // Mantém o console aberto para você visualizar o resultado
        }
    }
}
