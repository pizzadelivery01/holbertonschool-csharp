using System;


class MatrixMath
{
    /// <summary>
	/// inverse
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <returns>inverse matrix</returns>
	public static double[,] Inverse2D(double[,] matrix)
    {
		double[,] err = new double[,]{{-1}};

        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(0) != matrix.GetLength(1))
            return (err);

        double temp = matrix[1, 1];

        matrix[1, 1] = matrix[0, 0];
        matrix[0, 0] = temp;
        matrix[0, 1] *= -1;
        matrix[1, 0] *= -1;

        double det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        if (det != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Math.Round(matrix[i, j] / det, 2);

            return (matrix);
        }
        return (new double[,]{{-1}});
    }
}