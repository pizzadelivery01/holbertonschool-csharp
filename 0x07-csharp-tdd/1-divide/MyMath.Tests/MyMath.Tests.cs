using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// tests Matrix
    /// </summary>
    public class MatrixTests
    {
        /// <summary>
        /// test for divide by zero
        /// </summary>
        [Test]
        public void Divide_whenNumisZero_ReturnsNull()
        {
            int[, ] testmatrix = new int [2,4] {{5, 10, 20, 25}, {10, 20, 30, 40}};
            int[, ] newMatrix = Matrix.Divide(testmatrix, 0);
            Assert.AreEqual(null, newMatrix);
        }
        /// <summary>
        /// tests for null matrix
        /// </summary>
        [Test]
        public void Divide_whenMatrixisNull_ReturnsNull()
        {
            int[, ] testmatrix = null;
            int[, ] newMatrix = Matrix.Divide(testmatrix, 10);
            Assert.AreEqual(null, newMatrix);
        }
        /// <summary>
        /// test for division of matrix by number
        /// </summary>
        [Test]
        public void Divide_whenBothNotNUllorZero_ReturnsNewMatrix()
        {
            int[, ] testmatrix = new int [2,4] {{5, 10, 20, -25}, {10, 20, 30, 40}};
            int[, ] newMatrix = Matrix.Divide(testmatrix, 5);
            Assert.AreEqual(new int[2,4] {{1, 2, 4, -5}, {2, 4, 6, 8}}, newMatrix);
        }

    }
}
