using System;

class VectorMath
{
    /// <summary>
	/// cross product vectors
	/// </summary>
	/// <param name="vector1">vector1</param>
	/// <param name="vector2">vector2</param>
	/// <returns>vector</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return (new double[]{-1});

        double[] x = new double[3];

        x[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        x[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        x[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

        return (x);
    }
}