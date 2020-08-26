using System;

class VectorMath
{
    /// <summary>
    /// method that calculates length of a given vector
    /// </summary>
    /// <param name="vector">array containing vector</param>
    /// <returns>returns the length of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double x = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
          return -1;
        }
        foreach (double item in vector)
        {
            x += Math.Pow(x, 2);
        }
        return Math.Round(Math.Sqrt(x), 2);
    }
}