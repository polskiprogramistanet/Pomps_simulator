using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ChatRoom
{
    internal class UserInChat
    {
        public string Name { get; set; }
        public ChatRoom Room { get; set; }
        private List<string> _chatLog = new List<string>();
        public UserInChat(string name) => Name = name;
        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}' \n";
            Console.WriteLine($"[{Name}'s chat session] {s}");
            _chatLog.Add(s);
        }
        public void Say(string message) 
        { 
            Room.Broadcast(Name, message);  
        }
        public void PrivateMessage(string who, string message) 
        { 
            Room.Message(Name, who, message);
        }
    }
}
