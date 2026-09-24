using System.Reflection.PortableExecutable;

namespace XadrezConsole
{
    class Peca // Determina as informações da peça
    {
        public Posicao Posicao {get; set;} // Posição da peça no Tabuleiro.
        public Cor Cor { get; protected set;} // Determina a Cor da peça.
        public  int QteMovimentos {get; protected set;} // Conta a quantidade de Movimentos da peça.
        public Tabuleiro Tabuleiro {get; protected set;} // Determina a qual Tabuleiro a peça pertence.

        public Peca(Tabuleiro tabuleiro, Cor cor) // Obriga a informar o tabuleiro e a Cor ao criar uma nova peça.
        {
            Posicao = null; // A peça começa sem posição definida.
            Tabuleiro = tabuleiro;
            Cor = cor;
            QteMovimentos = 0; // Inicia sem movimentos feitos.
        }
    }
}