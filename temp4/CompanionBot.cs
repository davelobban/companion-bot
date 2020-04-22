using System;
using System.Collections.Generic;
namespace temp4
{
    internal class User {
        internal string Name;
        internal User(string name) {
            Name = name;
        }
    }
    public class CompanionBot
    {
        User _user;
        List<string> _messages;
        List<string> _unsentMessages= new List<string>();
        public CompanionBot() :this(new List<string>())
        { 
        }
        public CompanionBot(List<string> messages)
        {
            _user = new User("");
            _messages = messages;
        }

        public string Hello()
        {
            return "Hello";
        }

        public string MyNameIs(string name)
        {
            _user = new User(name);
            return $"Hello {_user.Name}";
        }

        public string HappyMe()
        {
            return $"Have a great day today {_user.Name}!";
        }

        public string Happier()
        {
            if (_unsentMessages.Count == 0)
            {
                _messages.ForEach(m => _unsentMessages.Add(m));
            }
            var numberOfUnsentMessages = _unsentMessages.Count;
            var index = new Random((int)DateTime.Now.Ticks%1000).Next(0, numberOfUnsentMessages - 1);
            var message = _unsentMessages[index];
            _unsentMessages.RemoveAt(index);
            return message;
        }
    }
}