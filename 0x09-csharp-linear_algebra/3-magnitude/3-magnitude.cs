﻿using System;

class VectorMath
{
    /// <summary>
    /// method that calculates length of a given vector
    /// </summary>
    /// <param name="vector">vector given</param>
    /// <returns>returns the length of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double x = 0;
        if (vector.Length == 3 || vector.Length == 2)
        {
        	foreach (double item in vector)
            	x += Math.Pow(x, 2);
        	return Math.Round(Math.Sqrt(x), 2);
    	}
		return -1;
    }
}