using System;
using System.Collections.Generic;

/// <summary>
/// vector math
/// </summary>
class VectorMath
{
    /// <summary>
	/// cross mult two vectors
	/// </summary>
	/// <param name="vector1">vector1</param>
	/// <param name="vector2">vector2</param>
	/// <returns>vector</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] X = new double[3];
		double[,] err = new double[] {-1};

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            x = new double[3] {
                (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]),
                (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]),
                (vector1[0] * vector2[1]) - (vector1[1] * vector2[0])
            };
            return (x);
        }
		else
		{
        	return (err);
		}
    }
}