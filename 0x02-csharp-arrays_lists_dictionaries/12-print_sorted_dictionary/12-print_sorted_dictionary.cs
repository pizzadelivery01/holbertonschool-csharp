using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> ordered_list = myDict.Keys.ToList();
        ordered_list.Sort();

        foreach(string key in ordered_list) 
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}