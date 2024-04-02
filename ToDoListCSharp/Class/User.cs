using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoListCSharp.Class
{
    public class User
    {
        private string name;
        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set {  password = value; } }

        public static void SignIn(List<User> users)
        {
            Console.Write("Votre pseudo : ");
            string name = Console.ReadLine();
            Console.Write("Votre mot de passe : ");
            string password = Console.ReadLine();

            User user1 = new(name, password);
            users.Add(user1);
            Console.WriteLine("Merci pour votre inscription");
        }

        public static void SignUp(List<User> users)
        {
            Console.Write("Le pseudo avec lequel vous vous êtes inscrit : ");
            string name = Console.ReadLine();
            Console.Write("Le mot de passe avec lequel vous vous êtes inscrit : ");
            string password = Console.ReadLine();
            
            foreach (User user in users)
            {
                if (user.Name == name && user.Password == password)
                {
                    Console.WriteLine("Vous êtes connecté");
                }
                else
                {
                    Console.WriteLine("Vos identifiants sont incorrects");
                }
            }

        }
    }
}
