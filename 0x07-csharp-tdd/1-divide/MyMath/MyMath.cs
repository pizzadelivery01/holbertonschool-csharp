using System;

namespace MyMath
{
    /// <summary>
    /// class for dividing all elements of a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// method that divides all elements of a matrix
        /// </summary>
        /// <param name="matrix">given matrix of numbers</param>
        /// <param name="num">number to divide by</param>
        /// <returns></returns>
        public static int[ , ] Divide(int[ , ] matrix, int num)
        {
            if (matrix == null)
                return null;
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            int [, ] newMatrix = new int [x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int result = (matrix[i,j] / num);
                    newMatrix[i, j] = result;
                }
            }
            return newMatrix;
        }
    }
}
