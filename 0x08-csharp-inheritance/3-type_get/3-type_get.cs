using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Represents a class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// checks properties and methods
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo type = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> propertiesList = type.GetProperties();
        IEnumerable<MethodInfo> methodsList = type.GetMethods();
        
        Console.WriteLine(type.Name + ' ' + "Properties:");
        foreach (PropertyInfo p in propertiesList)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(type.Name + ' ' + "Methods:");
        foreach (MethodInfo m in methodsList)
        {
            Console.WriteLine(m.Name);
        }
    }
}