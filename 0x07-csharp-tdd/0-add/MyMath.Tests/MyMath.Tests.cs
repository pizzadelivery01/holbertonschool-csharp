using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// tets operations 
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// test two ints added
        /// </summary>
        [Test]
        public void Add_TwoIntsAdded_ReturnsSum(
            [Values(1, 1000, -1000, 5)] int a,
            [Values(0, -1000, -100, 10)] int b)
            {
                var result = Operations.Add(a,b);

                Assert.That(result == (a + b));
            }
    }
}