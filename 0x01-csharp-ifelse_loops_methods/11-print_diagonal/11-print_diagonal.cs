using System;

class Line 
{
    public static void PrintDiagonal(int length)
    { 
        string line = "";
        if (length > 0) 
        {
            for (int i = 1; i <= length; i++)
            {
                line = new String(' ', i - 1);
                Console.WriteLine("{0}\\", line);
            }
        }
        Console.Write("\n");
    }
}