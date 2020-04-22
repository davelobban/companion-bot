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
            return _messages[0];
        }
    }
}