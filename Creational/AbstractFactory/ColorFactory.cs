using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return null;
        }

        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }

            return null;
        }
    }
}
