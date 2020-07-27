using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> pointer = myLList.First;
        for (; i < index && pointer.Next != null; i++)
            pointer = pointer.Next;
        if (i == index)
            myLList.Remove(pointer);
    }
}