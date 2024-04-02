using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCapital
{
    internal class Quizz
    {
        static List<string> countries =
        [
            "Allemagne",
            "France",
            "Espagne",
            "Italie",
            "Angleterre",
        ];

        static List<string> captiales =
        [
            "Berlin",
            "Paris",
            "Madrid",
            "Rome",
            "Londres",
        ];

        public static void Play()
        {
            while (true)
            {
                if (AskPlayOrReplay() == true)
                {
                    Game();
                } else
                {
                    return;
                }
            }
        }

        public static bool AskQuestion(int index)
        {
            Console.WriteLine($"Quelle est la capitale de {countries[index]} ?");
            string? rep = Console.ReadLine();
            if (rep == captiales[index])
            {
                Console.WriteLine("Bravo !!");
                return true;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse ! La bonne réponse était {captiales[index]} !");
                return false;
            }
        }

        public static void Game()
        {
            int counter = 0;
            for (int i = 0; i < countries.Count; i++)
            {
                if (AskQuestion(i) == true)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Vous avez eu {counter} bonnes réponses sur {countries.Count} !");
            Console.WriteLine();
        }

        public static bool AskPlayOrReplay()
        {
            Console.WriteLine("Vous voulez jouer ou rejouer ? O/N");
            string? restartGame = Console.ReadLine();
            if (restartGame == "O" || restartGame == "o")
            {
                Console.Clear();
                Console.WriteLine("Bonne chance");
                return true;
            }
            else {
                Console.Clear();
                Console.WriteLine("Merci d'avoir joué");
                return false;
            }
        }
    }
}
