using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();
        int quotient = 0;
            for (int i = 0; i < listLength; i++)
            {
                quotient = 0;
                try
                {
                    quotient = list1[i] / list2[i];
                    newList.Add(quotient);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    newList.Add(quotient);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        return (newList);
    }
}