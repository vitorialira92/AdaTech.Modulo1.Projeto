using System;
using System.Reflection;
using System.Text;

namespace JogoDaForcaLib
{
    public static class FuncionalidadesJogoDaForca
    {

        private static string word;
        private static string hint;
        private static string currentStateWord;
        private static string theme;
        private static int chances;

        private static List<string> pastWords = new List<string>();

        private static List<char> usedLetters = new List<char>();

        public static bool Jogo()
        {
            init(); //iniciando parâmetros do jogo

            bool stillPlaying = true;

            while(stillPlaying) { 
                ShowHangingMan();

                char letter = readChar();
                Console.Clear();
                if (TryToAddLetter(letter))
                {
                    if (DidTheyWin())
                    {
                        Console.WriteLine($"\n\nParabéns!! Você ganhou! A palavra era realmente {word}");
                        return true;
                    }
                    Console.WriteLine($"\n\nParabéns!! Realmente tem a letra {letter}");
                }
                else
                {
                    chances--;
                    if(chances == 0 )
                    {
                        Console.WriteLine($"\n\nAhh :/ você perdeu! A palavra era {word}");
                        return false;
                    }
                }

            }

            return false;

        }

        private static void init()
        {
            //seleção de tema
            Console.WriteLine("Iremos iniciar um novo jogo. Escolha o tema: ");
            Console.WriteLine("1 - GEOGRAFIA");
            Console.WriteLine("2 - EMPRESAS");
            Console.WriteLine("3 - HISTÓRIA MUNDIAL");
            Console.WriteLine("4 - ENTRETENIMENTO");
            Console.WriteLine("5 - TAYLOR SWIFT");

            int themeCode = readInteger(1, 5);
            
            //inicialização
            SetWord(themeCode);
            chances = 6;
            currentStateWord = String.Concat(Enumerable.Repeat("_", word.Length));
            if (word.Contains(' '))
            {
                StringBuilder aux = new StringBuilder(currentStateWord);
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == ' ')
                        aux[i] = ' ';
                }

                currentStateWord = aux.ToString();
            }
            usedLetters.Clear();

        }

        //lê um inteiro entre b (begin) e e (end), com esses inclusos
        private static int readInteger(int b, int e)
        {
            bool numberVerified = false;

            while(!numberVerified) {
                Console.Write("Digite um número: ");
                numberVerified = int.TryParse(Console.ReadLine(), out int number);
                if (numberVerified && number >= b && number <= e)
                    return number;

                Console.WriteLine("Tente novamente.");
            }
            return -1;
        }

        private static char readChar() {
            bool charVerified = false;

            while (!charVerified)
            {
                Console.Write("Digite uma letra: ");
                string txt = Console.ReadLine();

                Console.Clear();

                charVerified = txt.Length == 1 && Char.IsLetter(txt[0]);
            
                if (charVerified && !usedLetters.Contains(txt.ToUpper()[0]))
                {
                    usedLetters.Add(txt.ToUpper()[0]);
                    return txt.ToUpper()[0];
                }
                    

                if (txt.Length!=0 && usedLetters.Contains(txt.ToUpper()[0]))
                    Console.WriteLine("Letra já usada");

                Console.WriteLine("Tente novamente.");
            }
            return '1';
        }

        private static void ShowHangingMan()
        {
            string[] allHangingMen =
           {
                "    ___________\n"+
                "   |           |\n"+
                "   |         _____\n"+
                "   |\n"+
                "   |\n"+
                "   |\n"+
                "   |\n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |\n"+
                "   |\n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |\n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |            |\\ \n"+
                "   |            | \\ \n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |\n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |           /|\\ \n"+
                "   |          / | \\ \n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |\n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |           /|\\ \n"+
                "   |          / | \\ \n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |             \\ \n"+
                "   |              \\ \n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",

                "    ___________\n"+
                "   |           |\n"+
                "   |         --------\n"+
                "   |          ----\n"+
                "   |          |   |\n"+
                "   |          -----\n"+
                "   |           /|\\ \n"+
                "   |          / | \\ \n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |            |\n"+
                "   |           / \\ \n"+
                "   |          /   \\ \n"+
                "   |        "+ currentStateWord+ "\n"+
                "   |\n"+
                "   ____________\n",
            };

            Console.WriteLine($"--------- JOGO DA FORCA: {theme} ---------\n\n");
            Console.WriteLine($"A palavra tem {word.Length} letras\n");
            Console.WriteLine($"Uma dica..... {hint}\n");
            Console.WriteLine($"Você tem {chances} tentativas restantes\n\n");

            Console.WriteLine(allHangingMen[6 - chances] +  "\n\n");
            ShowPastLetters();

        }
        private static void SetWord(int themeCode)
        {
            string[,] chosenWord = new string[1, 2];

            bool palavraRepetida = false;

            do
            {
                switch (themeCode)
                {
                    case 1:
                        theme = "GEOGRAFIA";
                        chosenWord = Palavras.GetGeographyWord();
                        break;
                    case 2:
                        theme = "EMPRESAS";
                        chosenWord = Palavras.GetCompaniesWord();
                        break;
                    case 3:
                        theme = "HISTÓRIA MUNDIAL";
                        chosenWord = Palavras.GetWorldHistoryWord();
                        break;
                    case 4:
                        theme = "ENTRETENIMENTO";
                        chosenWord = Palavras.GetEntertainmentWord();
                        break;
                    case 5:
                        theme = "TAYLOR SWIFT";
                        chosenWord = Palavras.GetTaylorSwiftWord();
                        break;
                }

                palavraRepetida = pastWords.Contains(chosenWord[0,1]);

            } while (palavraRepetida);

            

            hint = chosenWord[0, 0];
            word = chosenWord[0, 1];
        }

        private static void ShowPastLetters()
        {
            if(usedLetters.Count > 0)
            {
                Console.Write("Letras já usadas: ");
                foreach(var word in usedLetters)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }
            
        }

        private static bool TryToAddLetter(char letter)
        {
            if(!word.Contains(letter))
                return false;

            StringBuilder aux = new StringBuilder(currentStateWord);
            for (int i = 0; i < word.Length; i++)
                if (word[i] == letter) aux[i] = letter;

            currentStateWord = aux.ToString();

            return true;
        }

        private static bool DidTheyWin()
        {
            return currentStateWord.Equals(word);
        }


    }
}
