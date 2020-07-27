using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> myList = new List<int>();
        int i = 0;
        int j = 0;
        while(i < list1.Count)
        {
            if(list2.Contains(list1[i]))
            {
                i++;
            }
            else
            {
                myList.Add(list1[i]);
                i++;
            }
        }
        while(j < list2.Count)
        {
            if(list1.Contains(list2[j]))
            {
                j++;
            }
            else
            {
                myList.Add(list2[j]);
                j++;
            }
        }
        myList.sort();
        return myList;
    }
}
