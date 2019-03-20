using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level) {
            this.level = level;
        }

        protected override void Write(string message) {
            Console.WriteLine("Error  Console::Logger: " + message);
        }
    }
}
