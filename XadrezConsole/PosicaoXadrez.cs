namespace XadrezConsole
{
    class PosicaoXadrez
    {
        public char Coluna {get; set;} // Letras das Colunas ( a, b, c, d, e, f, g, h)
        public int Linha {get; set;}   // Numeros das Linhas ( 1, 2, 3, 4, 5, 6, 7, 8)
    
        public PosicaoXadrez(char coluna, int linha) // Método que converte a posiçao no tabuleiro para a posiçao da Matriz do computador.
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao (8 - Linha, Coluna - 'a');
        }

        public override string ToString() // Personaliza a exibição da posição em formato de texto.
        {
            return "" + Coluna + Linha;
        }
    }
}