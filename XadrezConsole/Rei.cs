using System.Globalization;
using System.Reflection.PortableExecutable;

namespace XadrezConsole
{
    class Rei : Peca // A classe Rei herda (:) da classe Peca.
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) // Construtor que repassa o tabuleiro e a cor a classe mãe (Peca).
        {
        }

        public override string ToString() // Define o Caractere que vai representar o Rei no Tabuleiro.
        {
            return "R";
        }
    }
}