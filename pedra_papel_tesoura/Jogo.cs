namespace pedra_papel_tesoura
{
    class Jogo
    {
        public int Jogador1 { get; set; }
        public int Jogador2 { get; set; }

        public Jogo (int jogador1, int jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;

            if (jogador1 == 2 && jogador2 == 5)
            {
                System.Console.WriteLine("Jogador 1 venceu!");
            }
            else if(jogador1 == 5 && jogador2 == 2)
            {
                System.Console.WriteLine("Jogador 2 venceu!");
            }
            else if(jogador1 == 0 && jogador2 == 2)
            {
                System.Console.WriteLine("Jogador 1 venceu!");
            }
            else if (jogador1 == 2 && jogador2 == 0)
            {
                System.Console.WriteLine("Jogador 2 venceu!");
            }
            else if (jogador1 == 5 && jogador2 == 0)
            {
                System.Console.WriteLine("Jogador 1 venceu");
            }
            else if (jogador1 == 0 && jogador2 == 5)
            {
                System.Console.WriteLine("Jogador 2 venceu!");
            }
            else if(jogador1 == jogador2)
            {
                System.Console.WriteLine("Empate");
            }
        }
    }
}
