using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class RealCustomer: AbstractCustomer
    {
        public RealCustomer(string name) {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}
