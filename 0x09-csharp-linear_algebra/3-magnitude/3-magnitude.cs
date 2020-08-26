using System;

class VectorMath 
{
    /// <summary>
    /// Calculates vector length
    /// </summary>
    /// <param name="vector">vector given</param>
    /// <returns>returns the length of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double x = 0;
        if (vector.Length <= 3 && vector.Length > 1)
        {
            foreach (double entry in vector)
                x += Math.Pow(entry, 2);
            return(Math.Round(Math.Sqrt(x), 2));
        }
        return (-1);
    }
}