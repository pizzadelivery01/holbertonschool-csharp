using System;


class VectorMath
{
    /// <summary>
	/// multiplies vector by scalar
	/// </summary>
	/// <param name="vector">vector</param>
	/// <param name="scalar">scalar</param>
	/// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] x = new double[vector.Length];

        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] { -1 };
        }
        foreach (int i in vector)
        {
            x[i] = Math.Round((vector1[i] * scalar), 2);
        }

        return x;
    }
}