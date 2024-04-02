using ToDoListCSharp.Class;

List<User> users = [];

while (true)
{
    Console.WriteLine("=== Menu ===");
    Console.WriteLine("1. S'inscrire");
    Console.WriteLine("2. Se connecter");
    Console.WriteLine("3. Quitter");
    string rep = Console.ReadLine();

    switch (rep)
    {
        case "1":
            User.SignIn(users);
            break;
        case "2":
            User.SignUp(users);
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Cela ne fait pas parti des choix proposé");
            break;
    }
}