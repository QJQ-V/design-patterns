using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static Hashtable circleMap = new Hashtable();

        public static IShape GetCircle(string color)
        {
            Circle circle = (Circle)circleMap[color];

            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }

            return circle;
        }
    }
}
