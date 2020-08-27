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
        double[,] err = new double[,] {{-1}};
        double det;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (det == 0)
                return (err);
            double[,] x = new double[,] {
                {(1 / det) * matrix[1, 1], (1 / det) * -matrix[0, 1]},
                {(1 / det) * -matrix[1, 0], (1 / det) * matrix[0, 0]}
            };
            return (x);
        }
        return (err);
    }
}