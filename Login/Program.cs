using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Concat(username.Reverse());
            string type = Console.ReadLine();
            int counter = 0;
            bool isBlocked = false;

            while (type!=password)
            {
                counter++;
                if (counter==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    isBlocked = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
                type = Console.ReadLine();
            }
            if (isBlocked==false)
            {
                Console.WriteLine($"User {username} logged in.");

            }
           
        }
    }
}
