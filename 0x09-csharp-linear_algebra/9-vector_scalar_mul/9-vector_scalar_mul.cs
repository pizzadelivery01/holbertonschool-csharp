using System;


class VectorMath
{
    /// <summary>
    /// multiplies two vectors
    /// </summary>
    /// <param name="vector1">vector 1</param>
    /// <param name="vector2">vector 2</param>
    /// <returns>vector</returns>
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