﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain
{
    public class ConsoleLogger: AbstractLogger
    {
        public ConsoleLogger(int level) {
            this.level = level;
        }

        protected override void Write(string message) {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}
