using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        private static readonly string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
                circle.SetX(getRandomX());
                circle.SetY(getRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }

            Console.ReadKey();

        }

        private static string getRandomColor()
        {
            return colors[(int)(new Random().Next(1, 5))];
        }

        private static int getRandomX()
        {
            return (int)(new Random().Next(1,6) * 100);
        }
        private static int getRandomY()
        {
            return (int)(new Random().Next(1, 6) * 100);
        }
    }
}
