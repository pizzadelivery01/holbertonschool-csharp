using System;

class VectorMath
{
    /// <summary>
    /// multiplies a vector by a scalar
    /// </summary>
    /// <param name="vector">vector</param>
    /// <param name="scalar">scalar to multiply by</param>
    /// <returns>vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {

        if (vector.Length <= 3 && vector.Length >= 2)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= scalar;
            return (vector);
        }
        return (new double[1]{-1});
    }
}