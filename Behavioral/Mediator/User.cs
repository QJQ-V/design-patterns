using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public User(string name)
        {
            this.name = name;
        }

        public void SendMessage(String message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
