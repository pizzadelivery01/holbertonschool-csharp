  
using System;
class Program
{
    static void Main()
    {
        // methods that creates and prints a jagged array containing 3 arrays
        int[][] Jagged = new int[3][];

        Jagged[0] = new int[4] { 0, 1, 2, 3 };
        Jagged[1] = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
        Jagged[2] = new int[2] { 0, 1 };

        for (int i = 0; i < Jagged.Length; i++)
        {
            for (int j = 0; j < Jagged[i].Length; j++)
            {
                Console.Write("{0}{1}", Jagged[i][j], j == (Jagged[i].Length - 1) ? "" : " ");
            }
            Console.WriteLine();
        }
    }
}