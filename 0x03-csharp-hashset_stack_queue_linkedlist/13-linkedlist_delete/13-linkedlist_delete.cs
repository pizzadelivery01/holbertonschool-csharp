using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        
        LinkedListNode<int> index = myLList.First;
        for ( int i = 0; i < index && index.Next != null; i++)
            index = index.Next;
        if (i == index)
            myLList.Remove(index);
    }
}