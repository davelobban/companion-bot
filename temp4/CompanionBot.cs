using System;
using System.Diagnostics;

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

        public CompanionBot()
        {
            _user = new User("");
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
    }
}