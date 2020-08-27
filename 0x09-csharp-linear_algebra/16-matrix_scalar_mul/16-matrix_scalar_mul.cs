using System;

class MatrixMath
{
    /// <summary>
    ///  multiply matrix by scalar
    /// </summary>
    /// <param name="matrix"> Matrix </param>
    /// <param name="scalar">scalar</param>
    /// <returns>matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            return (new double[,]{{-1}});

        if (matrix.GetLength(0) >= 2 && matrix.GetLength(0) <= 3)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] *= scalar;
            return (matrix);
        }
        return (new double[,]{{-1}});
    }
}