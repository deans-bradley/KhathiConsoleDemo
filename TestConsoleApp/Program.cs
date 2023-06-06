using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            HomeController home = new HomeController();
            home.Menu();
        }
    }
}
