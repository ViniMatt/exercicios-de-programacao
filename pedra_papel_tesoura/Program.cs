using System;

namespace pedra_papel_tesoura
{
    class Program
    {
        static void Main(string[] args)
        {


            int jogador1, jogador2;

            jogador1 = 0;
            jogador2 = 0;

            while (jogador1 != 9 && jogador2 != 9)
            {
                Console.WriteLine();
                Console.WriteLine("2 = tesoura; 5 = papel; 0 = pedra;");
                Console.WriteLine();

                Console.Write("Jogador 1: ");
                jogador1 = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Jogador 2: ");
                jogador2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                new Jogo(jogador1, jogador2);
            }
            
            

                

        }
    }
}
