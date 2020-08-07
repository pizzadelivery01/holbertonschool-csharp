using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestNull()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(null));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("Hello"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("Hello World"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(4, Text.Str.CamelCase("Hello, Is it me You are looking For"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(2, Text.Str.CamelCase(" 12 Hello"));
        }
    }
}