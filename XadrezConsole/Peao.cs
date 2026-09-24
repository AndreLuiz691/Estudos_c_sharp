namespace XadrezConsole
{
    class Peao : Peca // A classe Peao herda (:) da classe Peca.
    {
        public Peao(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro,cor) // Construtor que repassa o tabuleiro e a cor para a classe mãe (Peca).
        {
        }

        public override string ToString() // Define o Caractere que vai representar o Peão no Tabuleiro.
        {
            return "P";
        }
    }
}