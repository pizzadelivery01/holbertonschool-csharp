using System;

class MatrixMath
{
	/// <summary>
	/// rotate matrix
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <param name="angle">rotate radians</param>
	/// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double [,] roto = new double[,] { {Math.Cos(angle), Math.Sin(angle)}, {Math.Sin(angle) * -1, Math.Cos(angle)}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,]{{-1}});

        double[,] x = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                    x[i, j] = Math.Round(x[i, j] + matrix[i, k] * roto[k, j], 2);
            }
        }
        return (x);
    }
}