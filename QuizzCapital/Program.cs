static void GameCapitales()
{
    List<string> countries =
[
    "Allemagne",
        "France",
        "Espagne",
        "Italie",
        "Angleterre",
    ];

    List<string> captiales =
    [
        "Berlin",
        "Paris",
        "Madrid",
        "Rome",
        "Londres",
    ];


    int counter = 0;
    foreach (string country in countries)
    {
        Console.WriteLine($"Quelle est la capitale de {country} ?");
        string? rep = Console.ReadLine();

        if (country == "Allemagne")
        {
            if (rep == "Berlin")
            {
                Console.WriteLine("C'est une bonne réponse !");
                counter++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse ! La réponse était " + captiales[0]);
            }
        }
        else if (country == "France")
        {
            if (rep == "Paris")
            {
                Console.WriteLine("C'est une bonne réponse !");
                counter++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse ! La réponse était " + captiales[1]);
            }
        }
        else if (country == "Italie")
        {
            if (rep == "Rome")
            {
                Console.WriteLine("C'est une bonne réponse !");
                counter++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse ! La réponse était " + captiales[3]);
            }
        }
        else if (country == "Espagne")
        {
            if (rep == "Madrid")
            {
                Console.WriteLine("C'est une bonne réponse !");
                counter++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse ! La réponse était " + captiales[2]);
            }
        }
        else if (country == "Angleterre")
        {
            if (rep == "Londres")
            {
                Console.WriteLine("C'est une bonne réponse !");
                counter++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse ! La réponse était " + captiales[4]);
            }
        }
    }
    Console.WriteLine($"Vous avez eu {counter} bonnes réponses sur {countries.Count} !");
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("Vous voulez jouer ou rejouer ? O/N");
    string? restartGame = Console.ReadLine();
    switch (restartGame)
    {
        case "O":
            Console.Clear();
            Console.WriteLine("Bonne chance");
            GameCapitales();
            break;
        case "o":
            Console.Clear();
            Console.WriteLine("Bonne chance");
            GameCapitales();
            break;
        case "N":
            Console.WriteLine("Merci d'avoir joué");
            return;
        default:
            Console.WriteLine("Ceci ne fait pas parti des solutions proposé !");
            break;
    }
}


