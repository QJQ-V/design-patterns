using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChickenBurger: Burger
    {
        public override string Name()
        {
            return "ChickenBurger Burger";
        }

        public override float Price()
        {
            return 50.5f;
        }
    }
}
