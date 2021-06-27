using KanbanAppDL;
using System;
using System.Collections.Generic;

namespace KanbanAppBL
{
    public class AdminAccount
    {
        public List<Admin> Account = new List<Admin>()
        {
            new Admin("Guiller","guiller")
        };
    
    public void LogIn()
        {

            NavigationFunction project = new NavigationFunction();
            bool successful = false;

            Console.WriteLine("Enter Admin:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (Admin user in Account)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("    ");
                    Console.WriteLine("Log in Success");
                    successful = true;
                    project.NaviFuntion();
                }   
            }
            if (!successful)
            {
                Console.WriteLine("Operation Cease...");
            }
        }
        public void Signup ()
        {
            NavigationFunction project = new NavigationFunction();
            Console.WriteLine("Enter new Username :");
            string newuser = Console.ReadLine();
            Console.WriteLine("Enter new Password :");
            string newpass = Console.ReadLine();

            Account.Add(new Admin(newuser, newpass));
            

            Console.WriteLine("    ");
            Console.WriteLine("You Signed Up Successfully!");

            foreach (Admin user in Account)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", user.UserName, user.PassWord);
                
            }
            project.NaviFuntion();
        }
        

    }
}
