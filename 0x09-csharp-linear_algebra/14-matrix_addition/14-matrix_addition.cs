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
        int len1 = matrix1.GetLength(1);
        int len2 = matrix2.GetLength(1);
        double[,] matrix_ret = new double[len1, len1];
        if ((len1 == 2 && len2 == 2) || (len1 == 3 && len2 == 3))
        {
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len1; j++)
                {
                    matrix_ret[i, j] += matrix2[i, j];
                }
            }
            return matrix_ret;
        }
        return (new double[,] {{-1}});
    }
}
