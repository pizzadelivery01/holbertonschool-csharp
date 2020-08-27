using System;

class MatrixMath
{
    /// <summary>
    /// Multiply two matrixes together
    /// </summary>
    /// <param name="matrix1">First matrix to multiple</param>
    /// <param name="matrix2">Second matrix to multiply</param>
    /// <returns>-1 on error, or the resulting matrix from te multiplication</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int m1_row = matrix1.GetLength(0);
        int m1_col = matrix1.GetLength(1);
        int m2_row = matrix2.GetLength(0);
        int m2_col = matrix2.GetLength(1);

        if (m1_col != m2_row)
            return (new double[,]{{-1}});

        double[,] x = new double[m1_row, m2_col];
        for (int i = 0; i < m1_row; i++)
        {
            for (int j = 0; j < m2_col; j++)
            {
                x[i, j] = 0;
                for (int k = 0; k < m1_col; k++)
                {
                    x[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return (x);
    }
}