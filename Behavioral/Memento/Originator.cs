using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string state;

        public void SetState(string state) {
            this.state = state;
        }

        public string GetState() {
            return state;
        }

        public Memento SaveStateToMemento() {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento) {
            state = memento.GetState();
        }
    }
}
