namespace XadrezConsole
{
    class Tabuleiro
    {
        public int Linhas { get; set;}
        public int Colunas { get; set;}
        private Peca[,] pecas; // Matriz para guardar as peças do tabuleiro.

        public Tabuleiro(int linhas, int coluna) // Construtor
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, coluna]; // Cria uma Matriz com o tamanho informado.
        }

        public Peca Peca(int linha, int coluna) // Método para pegar uma peça específica do tabuleiro e informar sua "Linha" e "Coluna".
        {
            return pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos) // Método para pegar uma peça usando a classe Posicao que criei no começo.
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos) // Método que verifica se ja existe uma peça em uma determinada posição.
        {
            return Peca(pos) != null; 
        }

        public void ColocarPeca(Peca p, Posicao pos) // Método que coloca uma peça no Tabuleiro.
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}