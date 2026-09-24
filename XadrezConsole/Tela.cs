using System;                                                              

namespace XadrezConsole                                                    
{
    class Tela       // Declara a classe estática Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)    // Método que imprime a partida completa
        {
            ImprimirTabuleiro(partida.Tabuleiro);          // Chama o método para desenhar o tabuleiro na tela
            Console.WriteLine();                              // Pula uma linha no console
            Console.WriteLine("Turno: " + partida.Turno);       // Imprime o número do turno atual
            Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual); // Imprime a cor do jogador da vez
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)     // Método responsável por desenhar a grade do tabuleiro
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)            // Loop para percorrer cada linha (0 a 7)
            {
                Console.Write(8 - i + " ");                        // Imprime o número da linha correspondente no xadrez (8 a 1)

                for (int j = 0; j < tabuleiro.Colunas; j++)      // Loop para percorrer cada coluna (0 a 7)
                {
                    ImprimirPeca(tabuleiro.Peca(i, j));       // Imprime a peça ou o espaço vazio da posição atual
                }
                Console.WriteLine();         // Quebra a linha após terminar a linha atual do tabuleiro
            }
            
            Console.WriteLine("  a b c d e f g h");        // Imprime as letras das colunas na parte inferior
        }

        public static void ImprimirPeca(Peca peca)     // Método auxiliar para imprimir uma peça ou casa vazia
        {
            if (peca == null)                       // Verifica se a posição está vazia (null)
            {
                Console.Write("- ");                 // Se estiver vazia, imprime um traço
            }
            else                                    // Se houver uma peça na posição
            {
                Console.Write(peca + " ");          // Imprime a representação em texto da peça (ex: T, R, B)
            }
        }
    }
}