﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample.ChatRoom
{
    internal class UserInChat
    {
        public string Name;
        public ChatRoom Room;
        private List<string> _chatLog = new List<string>();
        public UserInChat(string name) => Name = name;
        public void Recive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            Console.WriteLine($"[{Name}'s chat session] {s}");
            _chatLog.Add(s);
        }
        public void Say(string message) => Room.Broadcast(Name, message);
        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }
    }
}