using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp.Controller;

namespace TestConsoleApp
{
    public class HomeController
    {
        public void Menu() 
        {
            TaskController task = new TaskController();
            GoalController goal = new GoalController();
            StatsController stats = new StatsController();

            Console.WriteLine("********************\n" +
                              "KHATHI SHEETS\n" +
                              "********************\n" +
                              "1) Tasks\n" +
                              "2) Goals\n" +
                              "3) Stats\n" +
                              "4) Exit\n" +
                              "********************");
            string ans = Console.ReadLine();

            switch (ans)
            {
                case "1": task.Menu();
                    break;
                case "2": goal.Menu();
                    break;
                case "3": stats.View();
                    break;
                case "4": Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }
        }
    }
}
