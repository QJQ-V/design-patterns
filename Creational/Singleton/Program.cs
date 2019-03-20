using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.GetInstance();

            singleton.ShowMessage();

            Console.ReadKey();
        }
    }
}
