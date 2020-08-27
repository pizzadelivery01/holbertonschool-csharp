using System;
using System.Collections.Generic;

class MatrixMath
{
    /// <summary>
	/// shear 2d
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <param name="direction">shear direction</param>
	/// <param name="factor">shear factor</param>
	/// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] err = new double[,] {{-1}};
        double[,] shear_matrix = new double[2, 2] {{1, 0}, {0, 1}};
        double[,] x = new double[2, 2];
        double temp;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (err);
        }
        if (direction == 'x')
            shear_matrix[1, 0] = factor;
        else if (direction == 'y')
            shear_matrix[0, 1] = factor;
        else
            return (err);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                temp = 0;
                for (int k = 0; k < 2; k++)
                {
                    temp += matrix[i, k] * shear_matrix[k, j];
                }
                x[i, j] = Math.Round(temp, 2);
            }
        }
        return (x);
    }
}