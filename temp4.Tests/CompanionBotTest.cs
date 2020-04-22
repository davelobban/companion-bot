using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using temp4;
namespace temp4.Tests
{
    public class CompanionBotTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void HelloReturnsHello()
        {
            var sut = new CompanionBot();
            var actual = sut.Hello();
            Assert.AreEqual("Hello", actual);
        }

        [TestCase("Lee")]
        [TestCase("Tony")]
        public void MyNameIsReturnsHelloName(string name)
        {
            var sut = new CompanionBot();
            var actual = sut.MyNameIs(name);
            var expected = $"Hello {name}";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Lee")]
        [TestCase("Tony")]
        public void HappyMeIsReturnsMessagePlusName(string name)
        {
            var sut = new CompanionBot();
            sut.MyNameIs(name);
            var actual = sut.HappyMe();
            var expected = $"Have a great day today {name}!";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Lee")]
        [TestCase("Tony")]
        public void HappierReturnsSingleMessage(string name)
        {
            var message = "m1";
            var messages = new List<string> { message }; 
            var expected = new Dictionary<string, int> { { message, 1 } };
            var actual = new Dictionary<string, int>();

            var sut = new CompanionBot(messages);
            sut.MyNameIs(name);
            var returned = sut.Happier();
            TestContext.Out.WriteLine(returned);
            if (actual.ContainsKey(returned))
            {
                actual[returned]++;
            }
            else
            {
                actual.Add(returned, 1);
            }
            Assert.AreEqual(expected, actual);

        }
    }
}