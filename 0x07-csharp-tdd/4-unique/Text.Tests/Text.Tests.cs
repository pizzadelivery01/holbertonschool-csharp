using NUnit.Framework;

namespace Text.Tests
{
    public class Text_Tests
    {
        [Test]
        public void UniqueChar_whenStringNull_returnsNegOne()
        {
            string s = null;
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void UniqueChar_whenStringEmpty_returnsNegOne()
        {
            string s = "";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void UniqueChar_whenUnique_returnsOne()
        {
            string s = "hope";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void UniqueChar_whenAllNonUnique_returnsNegOne()
        {
            string s = "eeeeeeeeee";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void UniqueChar_whenUniqueSecond_returnsOne()
        {
            string s = "hohpe";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(2, result);
        }
    }
}