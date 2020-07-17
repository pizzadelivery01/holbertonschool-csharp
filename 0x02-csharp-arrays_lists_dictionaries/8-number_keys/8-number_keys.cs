using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    // method that returns the number of keys in a dictionary
    {
        int counter = 0;
        foreach(KeyValuePair<string, string> entry in myDict)
        {
            counter += 1;
        }
        return (counter);
    }
}