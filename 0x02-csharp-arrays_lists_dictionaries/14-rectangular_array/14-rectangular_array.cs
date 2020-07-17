using System;

class Program
{
    static void Main(string[] args)
    // method that creates and prints a 5 by 5 two-dimensional array and initialize index [2, 2] to 1 and all other indices to 0
    {
        var array = new int[5, 5];
        array[2, 2] = 1;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{array[i, 0]} {array[i, 1]} {array[i, 2]} {array[i, 3]} {array[i, 4]}");
        }
    }
}