﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Task
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime DueDate { get; set; }
        public Category category { get; set; }
        public bool IsCompleted { get; set; }
    }
}
