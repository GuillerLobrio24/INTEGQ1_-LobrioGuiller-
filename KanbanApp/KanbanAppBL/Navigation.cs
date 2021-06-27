using KanbanAppDL;
using System;
using System.Collections.Generic;
namespace KanbanAppBL
{
    public class Navigation
    {
        public List<Category> Navigate = new List<Category>()
        {
            new Category ("Assignment 1","Quiz 7","Seatwork 3","Assignment 2"),
        };

        public void ViewProjects()
        {
            Console.WriteLine(" Type the code of category you want to view ");
            Console.WriteLine(" Unopened Projects: (1)");
            Console.WriteLine(" Opened Projects: (2)");
            Console.WriteLine(" Finished Projects: (3)");
            Console.WriteLine(" Late Projects: (4)");

            int categoryInput = int.Parse(Console.ReadLine());

            switch (categoryInput)
            {
                case 1:
                    foreach (Category Navi in Navigate)
                    {
                        Console.WriteLine(Navi.Unopened);
                    }
                    break;
                case 2:
                    foreach (Category Navi in Navigate)
                    {
                        Console.WriteLine(Navi.Opened);
                    }
                    break;
                case 3:
                    foreach (Category Navi in Navigate)
                    {
                        Console.WriteLine(Navi.Finished);
                    }
                    break;
                case 4:
                    foreach (Category Navi in Navigate)
                    {
                        Console.WriteLine(Navi.Late);
                    }
                    break;

                default:
                    break;
            }
        }
        public void AddProjects()
        {
            Console.WriteLine(" Type the code of category you want to modify ");
            Console.WriteLine(" Unopened Projects: (1)");
            Console.WriteLine(" Opened Projects: (2)");
            Console.WriteLine(" Finished Projects: (3)");
            Console.WriteLine(" Late Projects: (4)");

            int categoryInput = int.Parse(Console.ReadLine());

            switch (categoryInput)
            {
                case 1:
                    {
                        Console.WriteLine("Add Unopened Projects: ");
                        string addUnopened = Console.ReadLine();
                        Navigate.Add(new Category(addUnopened,"","",""));
                    }
                    break;
                case 2:
                    {                   
                        Console.WriteLine("Add Opened Projects: ");
                        string addOpened = Console.ReadLine();
                        Navigate.Add(new Category("", addOpened, "", ""));
                    }
                    break;
                case 3:
                    {                   
                        Console.WriteLine("Add Finished Projects: ");
                        string addFinished = Console.ReadLine();
                        Navigate.Add(new Category( "", "", addFinished, ""));
;
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Add Late  Projects: ");
                        string addLate = Console.ReadLine();
                        Navigate.Add(new Category("", "", "", addLate));
                    }
                    break;
                default:
                    break;
            }

        }
        public void RemovedProjects()
        {
            Console.WriteLine(" Type the code of category you want to modify ");
            Console.WriteLine(" Unopened Projects: (1)");
            Console.WriteLine(" Opened Projects: (2)");
            Console.WriteLine(" Finished Projects: (3)");
            Console.WriteLine(" Late Projects: (4)");

            int categoryInput = int.Parse(Console.ReadLine());

            switch (categoryInput)
            {
                case 1:
                    Console.WriteLine("Enter Index Position of the Project you want to Remove:");
                    int indexPosition1 = int.Parse(Console.ReadLine());

                    Navigate.RemoveAt(indexPosition1);
                    break;
                case 2:
                    Console.WriteLine("Enter Index Position of the Project you want to Remove:");
                    int indexPosition2 = int.Parse(Console.ReadLine());

                    Navigate.RemoveAt(indexPosition2);
                    break;
                case 3:
                    Console.WriteLine("Enter Index Position of the Project you want to Remove:");
                    int indexPosition3 = int.Parse(Console.ReadLine());

                    Navigate.RemoveAt(indexPosition3);

                    break;
                case 4:
                    Console.WriteLine("Enter Index Position of the Project you want to Remove:");
                    int indexPosition4 = int.Parse(Console.ReadLine());

                    Navigate.RemoveAt(indexPosition4);
                    break;
                default:
                    break;
            }
            foreach (Category Navi in Navigate)
            {
                Console.WriteLine(Navi.Unopened, Navi.Opened, Navi.Finished, Navi.Late);
            }
        }
    }
}
