using System;

class VectorMath
{
	/// <summary>
	/// multiplies two vectors and returns the resulting vector
	/// </summary>
	/// <param name="vector1">vector</param>
	/// <param name="vector2">vector</param>
	/// <returns>vector</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double x = 0;

        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            return -1;
        }

        for (int i = 0; i < vector1.Length; i++)
        {
            x += (vector1[i] * vector2[i]);
        }

        return Math.Round(x, 2);
    }
}