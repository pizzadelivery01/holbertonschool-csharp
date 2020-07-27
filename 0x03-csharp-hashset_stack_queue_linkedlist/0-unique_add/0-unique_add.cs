using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> set = new HashSet<int>();
        foreach(int number in myList)
        {
            set.Add(number);
        }
        int size = set.Count;
        int total = 0;
        foreach (int item in set)
        {
            total = total + item;
        }

        return total;
    }
}
