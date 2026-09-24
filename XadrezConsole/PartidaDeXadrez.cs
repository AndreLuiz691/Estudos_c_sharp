using System;                                                              

namespace XadrezConsole                                                    
{
    class PartidaDeXadrez                  // Declara a classe controladora da partida
    {
        public Tabuleiro Tabuleiro { get; private set; }        // Tabuleiro da partida
        public int Turno { get; private set; }          // Número do turno atual
        public Cor JogadorAtual { get; private set; }        // Jogador da vez (Branca ou Preta)

        public PartidaDeXadrez()                    // Construtor da partida
        {
            Tabuleiro = new Tabuleiro(8, 8);        // Cria tabuleiro 8x8
            Turno = 1;                             // Inicia no turno 1
            JogadorAtual = Cor.Branca;            // Brancas começam
            ColocarPecas();                      // Posiciona as peças
        }

        public void ColocarNovaPeca(char coluna, int linha, Peca peca)  // Posiciona peça usando notação de xadrez
        {
            Tabuleiro.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao()); // Converte e coloca no tabuleiro
        }

        private void ColocarPecas()                      // Posiciona todas as peças iniciais
        {
            ColocarNovaPeca('c', 1, new Torre(Tabuleiro, Cor.Branca));     // Torre branca em c1
            ColocarNovaPeca('c', 2, new Torre(Tabuleiro, Cor.Branca));     // Torre branca em c2
            ColocarNovaPeca('d', 2, new Torre(Tabuleiro, Cor.Branca));     // Torre branca em d2
            ColocarNovaPeca('e', 2, new Torre(Tabuleiro, Cor.Branca));     // Torre branca em e2
            ColocarNovaPeca('e', 1, new Torre(Tabuleiro, Cor.Branca));     // Torre branca em e1
            ColocarNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branca));       // Rei branco em d1

            ColocarNovaPeca('c', 7, new Torre(Tabuleiro, Cor.Preta));      // Torre preta em c7
            ColocarNovaPeca('c', 8, new Torre(Tabuleiro, Cor.Preta));      // Torre preta em c8
            ColocarNovaPeca('d', 7, new Torre(Tabuleiro, Cor.Preta));      // Torre preta em d7
            ColocarNovaPeca('e', 7, new Torre(Tabuleiro, Cor.Preta));      // Torre preta em e7
            ColocarNovaPeca('e', 8, new Torre(Tabuleiro, Cor.Preta));      // Torre preta em e8
            ColocarNovaPeca('d', 8, new Rei(Tabuleiro, Cor.Preta));       // Rei preto em d8
        }
    }
}