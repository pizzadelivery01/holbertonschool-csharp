using System;

class Line 
{
    public static void PrintLine(int length)
    { 
        string line = "";
        if (length >= 0)
        {
            line = new String('_', length);
        }
        Console.WriteLine(line);
    }
}