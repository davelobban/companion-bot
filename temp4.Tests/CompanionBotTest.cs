using NUnit.Framework;
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
    }
}