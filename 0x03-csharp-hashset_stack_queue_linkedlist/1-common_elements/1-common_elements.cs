using System;
using System.Collections.Generic;

namespace common_elements
{
    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            List<int> myList = new List<int>();
            int i = 0;
            while(i < list1.Count)
            {
                if(list2.Contains(list1[i]))
                {
                    myList.Add(list1[i]);
                    i++;
                }
                else{
                    i++;
                }
            }
            return myList;
        }
    }
}
