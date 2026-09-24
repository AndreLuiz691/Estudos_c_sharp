namespace XadrezConsole
{
    class Cavalo : Peca // // A classe Cavalo herda (:) da classe Peca.
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro,cor) // // Construtor que repassa o tabuleiro e a cor para a classe mãe (Peca).
        {
        }  

        public override string ToString() // Define o Caractere que vai representar o Cavalo no Tabuleiro.
        {
            return "C";
        }
    }
}