using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 待维护
            IShape circle = new Circle();

            IShape redCircle = new RedShapeDecorator(new Circle());

            RedShapeDecorator redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();

            Console.ReadKey();
        }
    }
}
