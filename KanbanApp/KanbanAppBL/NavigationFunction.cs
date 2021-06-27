using System;
using System.Collections.Generic;
using System.Text;

namespace KanbanAppBL
{
    public class NavigationFunction
    {
        public void NaviFuntion()
        {
            Navigation ProjectFuntion = new Navigation();

        START:
            
            Console.WriteLine(" View Project (1) ");
            Console.WriteLine(" Add Project (2) ");
            Console.WriteLine(" Remove Project (3) ");
            Console.WriteLine(" Exit (4) ");
            
            int userInput = int.Parse(Console.ReadLine());
            
            switch (userInput)
            {
                case 1:
                    ProjectFuntion.ViewProjects();
                    goto START;
                case 2:
                    ProjectFuntion.AddProjects();
                    goto START;
                case 3:
                    ProjectFuntion.RemovedProjects();
                    goto START;

                default:
                    break;
            }
        }



    }
}
