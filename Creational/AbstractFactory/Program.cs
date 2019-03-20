using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取形状工厂
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //获取形状为 Circle 的对象
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //调用 Circle 的 draw 方法
            shape1.Draw();

            //获取形状为 Rectangle 的对象
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //调用 Rectangle 的 draw 方法
            shape2.Draw();

            //获取形状为 Square 的对象
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //调用 Square 的 draw 方法
            shape3.Draw();

            //获取颜色工厂
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");

            //获取颜色为 Red 的对象
            IColor color1 = colorFactory.GetColor("RED");

            //调用 Red 的 fill 方法
            color1.Fill();

            //获取颜色为 Green 的对象
            IColor color2 = colorFactory.GetColor("GREEN");

            //调用 Green 的 fill 方法
            color2.Fill();

            //获取颜色为 Blue 的对象
            IColor color3 = colorFactory.GetColor("BLUE");

            //调用 Blue 的 fill 方法
            color3.Fill();

            Console.ReadKey();
        }
    }
}
