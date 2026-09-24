using System.Reflection.PortableExecutable;

namespace XadrezConsole
{
    class Dama : Peca // A classe Dama herda (:) da classe Peca.
    {
        public Dama(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro,cor) // Construtor que repassa o tabuleiro e a cor para a classe mãe (Peca).
        {
        }

        public override string ToString() //Define o Caractere que vai representar a Dama no Tabuleiro.
        {
            return "D";
        }
    }
}