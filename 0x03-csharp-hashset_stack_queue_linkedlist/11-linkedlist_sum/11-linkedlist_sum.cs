using System;
using System.Collections.Generic;
class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total = 0;
        foreach (int number in myLList)
            total += number;
        return (total);
    }
}