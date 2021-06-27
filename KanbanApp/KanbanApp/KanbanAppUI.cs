using KanbanAppBL;
using System;

namespace KanbanApp
{
    class KanbanAppUI
    {
        static void Main(string[] args)
        {
            AdminAccount user = new AdminAccount();
            

            Console.WriteLine("Welcome to Kanban Project Management App");
            Console.WriteLine("Enter Admin Account (1)");
            Console.WriteLine("Signup (2)");
            
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Signup();
            }
            else
            {

            }
            
        }
    }
} 
