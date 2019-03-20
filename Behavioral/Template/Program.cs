using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();

            Console.WriteLine();

            game = new Football();
            game.Play();

            Console.ReadKey();
        }
    }
}
