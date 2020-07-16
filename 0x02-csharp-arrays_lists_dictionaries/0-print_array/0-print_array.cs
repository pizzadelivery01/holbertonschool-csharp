using System;


class Array
{
    public static int[] CreatePrint(int size)
    // method that prints an array of int to a given size
    {
        if(size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
            throw new OverflowException();
        }
        int[] int_array = new int[size];
        for(int i =0; i < size; i++)
        {
            Console.Write("{0}", i);
            if(i != (size - 1))
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return int_array;
    }
}