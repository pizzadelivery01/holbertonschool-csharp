using System;

class MatrixMath
{
	/// <summary>
	/// adding matix
	/// </summary>
	/// <param name="matrix1"></param>
	/// <param name="matrix2"></param>
	/// <returns>matrix</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0))
            return (new double[,]{{-1}});

        if (matrix1.Length == matrix2.Length && matrix1.GetLength(0) >= 2 && matrix1.GetLength(0) <= 3)
        {
            if (matrix1.GetLength(1) == matrix2.GetLength(1))
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                        matrix1[i, j] += matrix2[i, j];
                return (matrix1);
            }
        }
        return (new double[,] {{-1}});
    }
}
