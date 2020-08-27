
using System;
using System.Collections.Generic;

class MatrixMath
{
    /// <summary>
	/// Gets Dererminant
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <returns>double</returns>
    public static double Determinant(double[,] matrix)
    {
        double[,] err = new double[,] {{-1}};
        double det = 0;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = Math.Round((matrix[0, 0] * matrix[1, 1] - (matrix[0, 1] * matrix[1, 0])), 2);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            det = Math.Round(
                (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) +
                (matrix[2, 0] * matrix[0, 1] * matrix[1, 2]) -
                (matrix[0, 0] * matrix[2, 1] * matrix[1, 2]) -
                (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) -
                (matrix[1, 0] * matrix[0, 1] * matrix[2, 2]), 2);
        }
        else
        {
            return (-1);
        }
        return (det);
    }
}