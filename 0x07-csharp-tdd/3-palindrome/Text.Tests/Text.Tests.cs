using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void IsPalindrome_whenIsPalindrome_returnsTrue()
        {
            bool check = Str.IsPalindrome("racecar");
            Assert.IsTrue(check);
        }

        [Test]
        public void IsPalindrome_whenIsNotPalindrome_returnsFalse()
        {
            bool check = Str.IsPalindrome("this is not");
            Assert.IsFalse(check);
        }

        [Test]
        public void IsPalindrome_whenStringEmpty_returnsTrue()
        {
            bool check = Str.IsPalindrome("");
            Assert.IsTrue(check);
        }
        [Test]
        public void IsPalindrome_whenNull_returnsFalse()
        {
            bool check = Str.IsPalindrome(null);
            Assert.IsFalse(check);
        }
    }
}