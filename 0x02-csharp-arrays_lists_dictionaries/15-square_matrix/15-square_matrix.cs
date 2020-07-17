using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    // method that returns the square value of all integers of a matrixin new matrix.
    {
        int[,] squared = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];

        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                squared[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return (squared);
    }
}