using System.Reflection.PortableExecutable;

namespace XadrezConsole
{
    class Torre : Peca // A classe Torre herda (:) da classe Peca.
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) // Construtor que repassa o tabuleiro e a cor a classe mãe (Peca).
        {
        }

        public override string ToString() // Define o Caractere que vai representar a Torre no Tabuleiro.
        {
            return "T";
        }
    }
}