using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp;

namespace TestConsoleApp.Controller
{
    public class TaskController
    {
        public static List<Task> Tasks = new List<Task>();

        public void Menu()
        {
            HomeController home = new HomeController();

            Console.WriteLine("********************\n" +
                              "TASKS\n" +
                              "********************\n" +
                              "1) View Tasks\n" +
                              "2) Create Task\n" +
                              "3) Complete Task\n" +
                              "4) Completed Tasks\n" +
                              "5) Main Menu\n" +
                              "********************");
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1": View();
                    break;
                case "2": Create();
                    break;
                case "3": Complete();
                    break;
                case "4": Completed();
                    break;
                case "5": home.Menu();
                    break;
                default: Menu();
                    break;
            }
        }

        public void View()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].IsCompleted == false)
                {
                    Console.WriteLine("\n----------------------------------------\n" +
                                      Tasks[i].Name +
                                      "\n----------------------------------------" +
                                      "\nNotes: " + Tasks[i].Notes +
                                      "\nDue Date: " + Tasks[i].DueDate.ToString() +
                                      "\nCategory: " + Tasks[i].category.Name);
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter any key to return to Task Menu");
            Console.ReadLine();
            Menu();
        }

        public void Create()
        {
            Task task = new Task();
            Program program = new Program();

            string name;
            string notes;
            string dueDate;
            Category category;

            Console.WriteLine("Task name: ");
            name = Console.ReadLine();

            Console.WriteLine("Notes: ");
            notes = Console.ReadLine();

            Console.WriteLine("Due date: ");
            dueDate = Console.ReadLine();

            Console.WriteLine("********************\n" +
                              "1) Work\n" +
                              "2) School\n" +
                              "3) Recreation\n" +
                              "4) Errand\n" +
                              "5) Other\n" +
                              "********************\n" +
                              "Please select a Category");
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1": category = new Category { Name = "Work", Hours = 0 };
                    break;
                case "2": category = new Category { Name = "School", Hours = 0 }; 
                    break;
                case "3": category = new Category { Name = "Recreation", Hours = 0 };
                    break;
                case "4": category = new Category { Name = "Errand", Hours = 0 };
                    break;
                case "5": category = new Category { Name = "Other", Hours = 0 };
                    break;
                default: category = new Category { Name = "Other", Hours = 0 };
                    break;
            }

            task.Name = name;
            task.Notes = notes;
            task.DueDate = DateTime.Parse(dueDate);
            task.category = category;

            Tasks.Add(task);

            Console.WriteLine("TASK CREATED!\n" +
                              "Enter any key to return to Task Menu");
            Console.ReadLine();
            Menu();
        }

        public void Complete()
        {
            Console.WriteLine("TASKS");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine("\n----------------------------------------\n" +
                                  Tasks[i].Name );
            }

            Console.WriteLine("----------------------------------------\n" +
                  "Enter the task name you wish to have completed:");
            string result = Console.ReadLine();

            for (int i = 0; i < Tasks.Count; i++)
            {
                if (result.ToUpper() == Tasks[i].Name.ToUpper())
                {
                    Tasks[i].IsCompleted = true;
                }
            }

            Console.WriteLine("TASK UPDATED!\n" +
                              "Enter any key to return to Task Menu");
            Console.ReadLine();
            Menu();
        }

        public void Completed()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].IsCompleted == true)
                {
                    Console.WriteLine("\n----------------------------------------\n" +
                                      Tasks[i].Name +
                                      "\n----------------------------------------" +
                                      "\nNotes: " + Tasks[i].Notes +
                                      "\nDue Date: " + Tasks[i].DueDate.ToString() +
                                      "\nCategory: " + Tasks[i].category.Name);
                }
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter any key to return to Task Menu");
            Console.ReadLine();
            Menu();
        }
    }
}
