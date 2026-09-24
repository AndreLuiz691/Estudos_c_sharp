using System.Reflection.PortableExecutable;

namespace XadrezConsole
{
    class Bispo : Peca // A classe Bispo herda (:) da classe Peca.
    {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) // Construtor que repassa o tabuleiro e a cor a classe mãe (Peca).
        {
        }

        public override string ToString() // Define o Caractere que vai representar o Bispo no Tabuleiro.
        {
            return "B";
        }
    }
}