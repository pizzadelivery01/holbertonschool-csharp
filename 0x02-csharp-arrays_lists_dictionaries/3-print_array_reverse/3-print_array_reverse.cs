using System;

class Array
{
    public static void Reverse(int[] array)
    // method that prints all integers of an array, in reverse order
    {
        if (array == null)
        {
            Console.WriteLine();
        }
        else
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    Console.Write($"{array[i]} ");
                else
                    Console.Write($"{array[i]}");
            }
            Console.WriteLine();
        }
    }
}