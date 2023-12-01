namespace JogoDaForca
{
    using JogoDaForcaLib;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!! Bem-vindx!! Vamos iniciar um jogo!");
            bool keepPlaying = true;
            int gamesWon = 0;

            while(keepPlaying)
            {
                if (FuncionalidadesJogoDaForca.Jogo())
                    gamesWon++;
                else
                    Console.WriteLine("Não foi dessa vez que você ganhou hahah");

                Console.WriteLine($"Você já ganhou {gamesWon} jogos!! Você gostaria de jogar novamente? \nDigite Y para sim e qualquer outra coisa para não");
                string txt = Console.ReadLine();
                if (txt.Length != 1 || txt.ToUpper()[0] != 'Y' )
                    keepPlaying = false;
            }

            
        }

        
    }
}
