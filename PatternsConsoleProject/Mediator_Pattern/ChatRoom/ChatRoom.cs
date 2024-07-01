using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ChatRoom
{
    internal class ChatRoom
    {
        private List<UserInChat> _users = new List<UserInChat>();
        public void Broadcast(string source, string message)
        {
            foreach(var p in _users)
            {
                if(p.Name != source)
                    p.Receive(source, message);
            }
        }
        public void Join(UserInChat p)
        {
            string joinMsg = $"{p.Name} joins the chat \n";
            _users.Add(p);
            Broadcast("room", joinMsg);
            p.Room = this;
            
        }
        public void Message(string source, string destination, string message) 
        { 
            _users.FirstOrDefault(p => p.Name == destination)
                ?.Receive(source, message);
        }
    }
}
