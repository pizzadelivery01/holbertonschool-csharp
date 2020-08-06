using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// class to test operations max
    /// </summary>
    public class Operations_Tests
    {

        [Test]
        /// <summary>
        /// test when list is empty
        /// </summary>
        public void Max_whenNumsIsEmpty_returnZero()
        {
            List<int> nums = new List<int>();

            int maxVal = Operations.Max(nums);
            Assert.AreEqual(0, maxVal);
        }
        
        [Test]
        /// <summary>
        /// test when list is null
        /// </summary>
        public void Max_whenNumsIsNull_returnZero()
        {
            List<int> nums = null;

            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }

        [Test]
        /// <summary>
        /// test max value
        /// </summary>
        public void Max_whenNums_returnMaxVal()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(100);
            nums.Add(-204);

            int maxVal = Operations.Max(nums);
            Assert.AreEqual(100, maxVal);
        }
    }
}
