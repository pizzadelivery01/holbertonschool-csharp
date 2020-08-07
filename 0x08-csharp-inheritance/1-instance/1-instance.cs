using System;

/// <summary> Represents a class Obj</summary>
class Obj
{
    /// <summary> checks if obj is instance of Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}