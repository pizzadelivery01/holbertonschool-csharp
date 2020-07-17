using System;
using System.Collections.Generic;

class List
{
    public static void DeleteAt(List<int> myList, int index)
    // method that deletes list item at given index
    {
        int flag = 0;

        if (index > myList.Count - 1 || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return;
            throw new IndexOutOfRangeException();
        }
        foreach (int item in myList)
        {
            if (flag == index)
            {
                myList.Remove(myList[index]);
                break;
            }
            flag++;
        }
    }
}