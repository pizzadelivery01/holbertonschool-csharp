using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    // method that replaces an element of an array at a given index
    {
        if (index > array.Length - 1 | index < 0)
        {
            Console.WriteLine("Index out of range");
            return array;
            throw new IndexOutOfRangeException();
        }
        else
        {
            array[index] = n;
            return array;
        }
    }
}