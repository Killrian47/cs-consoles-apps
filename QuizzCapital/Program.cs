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
    for (int i = 0; i < countries.Count; i++)
    {
        Console.WriteLine($"Quelle est la capitale de {countries[i]} ?");
        string? rep = Console.ReadLine();
        if ( rep == captiales[i] )
        {
            Console.WriteLine("C'est une bonne réponse !");
            counter++;
        } else
        {
            Console.WriteLine($"Mauvaise réponse ! La réponse était {captiales[i]}");
        }
    }
    
    Console.WriteLine($"Vous avez eu {counter} bonnes réponses sur {countries.Count} !");
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("Vous voulez jouer ou rejouer ? O/N");
    string? restartGame = Console.ReadLine();
    if (restartGame == "O" || restartGame == "o")
    {
        Console.Clear();
        Console.WriteLine("Bonne chance");
        GameCapitales();
    } else if (restartGame == "N" || restartGame == "n") 
    {
        Console.Clear();
        Console.WriteLine("Merci d'avoir joué");
        return;
    }
    else
    {
        Console.WriteLine("Votre réponse ne fait pas partie des choix proposés");
    }
}


