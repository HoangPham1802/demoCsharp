using System;
using System.Collections;

namespace demo
{
    public class User
    {
        public string nameUser;
        public string passUser;
        public User(string nameUser, string passUser) {
            this.nameUser = nameUser;
            this.passUser = passUser;
        }
    }

    class Program
    {
        static ArrayList userList = new ArrayList();
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void inputUser()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter pass: ");
            string pass = Console.ReadLine();

            User user = new User(name, pass);
            userList.Add(user);
        }
        public static void show()
        {
            Console.WriteLine("1");
            foreach (User obj in userList)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("UserName: " + obj.nameUser);
                Console.WriteLine("UserPassword: " + obj.passUser);
                Console.WriteLine("----------------------------");
            }
        }
        public static void Menu()
        {
            while (true)
            {
                

                int choice = 0;
                Console.WriteLine("---Menu---");
                Console.WriteLine("1.Add User");
                Console.WriteLine("2.Display User");
                Console.WriteLine("3.Exit");
                Console.WriteLine("----------");
                choice = int.Parse(Console.ReadLine());  

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please add new user");
                        inputUser();
                        break;
                    case 2:
                        Console.WriteLine("Please display user list");
                        show();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}