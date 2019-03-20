using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private IState state;

        public Context() {
            state = null;
        }

        public void SetState(IState state) {
            this.state = state;
        }

        public IState GetState() {
            return state;
        }
    }
}
