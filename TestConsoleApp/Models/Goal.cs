using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Goal
    {
        public string Name { get; set; }
        Task task { get; set; }
        public int DailyHours { get; set; }
        public string Notes { get; set; }
        public DateTime DueDate { get; set; }
    }
}
