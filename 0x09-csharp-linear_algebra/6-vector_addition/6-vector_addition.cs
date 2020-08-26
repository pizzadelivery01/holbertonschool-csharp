using System;

class VectorMath
{
    /// <summary>
    /// add two vectors
    /// </summary>
    /// <param name="vector1">vector 1</param>
    /// <param name="vector2">vector 2</param>
    /// <returns>new vector</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] vector_return = { 0, 0 };
            vector_return[0] = vector1[0] + vector2[0];
            vector_return[1] = vector1[1] + vector2[1];
            return vector_return;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] vector_return = { 0, 0, 0 };
            vector_return[0] = vector1[0] + vector2[0];
            vector_return[1] = vector1[1] + vector2[1];
            vector_return[2] = vector1[2] + vector2[2];
            return vector_return;
        }
        return new double[] { -1 };
    }
}