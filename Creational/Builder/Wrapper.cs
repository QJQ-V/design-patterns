using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Wrapper: IPacking
    {
        public string Pack() {
            return "Wrapper";
        }
    }
}
