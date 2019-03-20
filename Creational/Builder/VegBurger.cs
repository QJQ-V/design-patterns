using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }
}
