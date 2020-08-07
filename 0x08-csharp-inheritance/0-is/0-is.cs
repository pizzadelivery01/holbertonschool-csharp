  
using System;

/// <summary> Represents a class Obj</summary>
class Obj
{
    /// <summary> checks if int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}
