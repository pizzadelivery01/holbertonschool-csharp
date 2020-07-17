using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        myDict = myDict.ToDictionary(k => k.Key, v => v.Value * 2);
        return (myDict);
    }
}