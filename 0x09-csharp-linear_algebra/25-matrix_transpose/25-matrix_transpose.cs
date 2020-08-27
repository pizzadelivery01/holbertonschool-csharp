using System;

class MatrixMath
{
	/// <summary>
	/// transpose matrix
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <returns>matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] err = new double[,] {{-1}};
        double[,] x = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                x[i, j] = matrix[j, i];
            }
        }
        return (x);
    }
}