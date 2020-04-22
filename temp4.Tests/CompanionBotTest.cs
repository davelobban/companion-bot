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

        [TestCase("Lee", 4)]
        [TestCase("Tony", 40)]
        public void HappierReturnsFourMessagesInEqualDistribution(string name, int numberOfTimesToCallMethod)
        {
            var message = "m1";
            var message2 = "m2";
            var message3 = "m3";
            var message4 = "m4";

            var messages = new List<string> { message, message2, message3, message4 };
            var expectedCountOfEachMessage = numberOfTimesToCallMethod / 4;
            var expected = new Dictionary<string, int> { { message, expectedCountOfEachMessage }, { message2, expectedCountOfEachMessage }, { message3, expectedCountOfEachMessage },
                { message4, expectedCountOfEachMessage  } };

            var sut = new CompanionBot(messages);
            sut.MyNameIs(name);
            Dictionary<string, int> actual = CallHappier(sut, numberOfTimesToCallMethod);
            Assert.AreEqual(expected, actual);

            static Dictionary<string, int> CallHappier(CompanionBot sut, int callCount)
            {
                var actual = new Dictionary<string, int>();
                for (var i = 0; i < callCount; i++)
                {
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
                }
                return actual;
            }
        }
    }
}