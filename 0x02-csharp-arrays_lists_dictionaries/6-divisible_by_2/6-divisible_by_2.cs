using System;
using System.Collections.Generic;

class List 
{
    public static List<bool> DivisibleBy2(List<int> myList)
    // returns list of T/F if multiple of 2
    {
        int counter = 0;
        List<bool> mul_of_two = new List<bool>();

        for (counter = 0; counter <= myList.Count - 1; counter++) {
            mul_of_two.Add((myList[counter] % 2 == 0) ? true : false);
        }
        return (mul_of_two);
    }
}