using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    // method that returns the key with the biggest integer value in a given dictionary
    {
        int max_value = 0;
        string max_key = "None";

        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value >= max_value)
            {
                max_value = item.Value;
                max_key = item.Key;
            }
        }
        return max_key;
    }
}