using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> index = myLList.First;
        if (index == null)
        {
            myLList.AddFirst(newNode);
            return (newNode);
        }
        if (index.Value > n)
        {
            myLList.AddBefore(index, newNode);
            return (newNode);
        }
        while (index.Next != null)
        {
            if (index.Next.Value >= n)
                break;
            index = index.Next;
        }
        myLList.AddAfter(index, newNode);
        return (newNode);
    }
}