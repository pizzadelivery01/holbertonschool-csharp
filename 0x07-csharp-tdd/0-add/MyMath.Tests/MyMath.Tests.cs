using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// tets operations 
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// test two positive
        /// </summary>
        [Test]
        public void PositivesTests()
        {
            int result = Operations.Add(6, 4);
            Assert.AreEqual(10, result);
        }
        /// <summary>
        /// tests if one negative
        /// </summary>
        /// <value></value>
        [TEST]
        public void OneNegativeTests()
            {
                int result = Operations.Add(5, -10);
                Assert.AreEqual(-5, result);
            }
        /// <summary>
        /// test two negatives
        /// </summary>
        [TEST]
        public void BothNegativeTests()
            {
                int result = Operations.Add(-6, -4);
                Assert.AreEqual(-10, result);
            }
    }
}