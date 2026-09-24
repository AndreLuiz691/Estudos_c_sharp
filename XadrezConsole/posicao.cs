namespace XadrezConsole
{
    class posicao // Localiza as Peças do tabuleiro.
    {
        public int Linha { get; set;} // Onde se armazena numeros inteiros referentes a "Linha".

        public int Coluna {get; set;} // Onde se armazena numeros inteiros agora referentes a "Coluna".
        
        public posicao(int linha, int coluna ) // Intrução que obriga a informar a "Linha" e a "Coluna" toda vez que uma nova posição é criada.
        {
            Linha = linha;
                              // } Salvam os valores recebidos de fora nas variáveis internas da classe para não os perdê-los.
            Coluna = coluna;
        }

        public override string ToString() //Personaliza a forma como a posição é exibida, transformando os valores recebidos da classe em um texto legível.
        {
                return $"{Linha}, {Coluna}"; // Devolve a linha e a coluna unidas em um formato de texto.
        }
    }
}