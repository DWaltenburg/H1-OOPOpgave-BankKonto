using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOpgave
{
    internal class Program
    {
        static UserInterface[] userInterfaces = { };
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. New User");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Name:");
                        userInterfaces = userInterfaces.Append(new UserInterface(Console.ReadLine())).ToArray();
                        break;
                    case "2":
                        Console.WriteLine("Name:");
                        UserInterface user = Login(Console.ReadLine());
                        user?.ShowMenu();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Unknown Command");
                        break;
                }
            }
        }
        static UserInterface Login(string username)
        {
            foreach (var user in userInterfaces)
            {
                if (user.name == username) { return user; }
            }
            return null;
        }
    }
}
