using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// interface for interactive
/// </summary>
interface IInteractive
{
	/// <summary>
	/// interact
	/// </summary>
	void Interact();
}
/// <summary>
/// interface for breakable
/// </summary>
interface IBreakable
{
	/// <summary>
	/// durability
	/// </summary>
	/// <value>int</value>
	int durability {get; set;}
	/// <summary>
	/// method to break 
	/// </summary>
	void Break();
}
/// <summary>
/// interface for collectable
/// </summary>
interface ICollectable
{
	/// <summary>
	/// is item collected
	/// </summary>
	/// <value>bool</value>
	bool isCollected {get; set;}
	/// <summary>
	/// method to collect
	/// </summary>
	void Collect();
}


/// <summary>
/// Base class abstract
/// </summary>
public abstract class Base
{
	/// <summary>
	/// Name
	/// </summary>
	/// <value>string</value>
	public string name {get; set;}
	/// <summary>
	/// overridee ToString method
	/// </summary>
	/// <returns>string</returns>
	public override string ToString()
	{
		return  (name + " is a " + this.GetType().ToString());
	}
}
/// <summary>
/// door class from base and interactive
/// </summary>
class Door : Base, IInteractive
{
	/// <summary>
	/// Door constructor
	/// </summary>
	/// <param name="Doorname">name</param>
	public Door(string Doorname = "Door")
	{
		name = Doorname;
	}
	/// <summary>
	/// interact method
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}
	/// <summary>
	/// class decoration
	/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
	public int durability {get; set;}
	public bool isQuestItem;
	/// <summary>
	/// decoration
	/// </summary>
	/// <param name="name">name</param>
	/// <param name="durability">durability</param>
	/// <param name="isQuestItem">Quest item?</param>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability < 1)
			throw new Exception("Durability must be greater than 0");
    	this.name = name;
   		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}
	/// <summary>
	/// interact method
	/// </summary>
	public void Interact()
	{
		if (durability < 1)
			Console.WriteLine($"The {name} has been broken.");
		else if (isQuestItem == true)
			Console.WriteLine($"You look at the {name}. There's a key inside.");
		else
			Console.WriteLine($"You look at the {name}. Not much to see here.");
	}
	/// <summary>
	/// break method
	/// </summary>
	public void Break()
	{
		durability -= 1;
    	if (durability > 0)
    		Console.WriteLine($"You hit the {name}. It cracks.");
    	else if (durability == 0)
    		Console.WriteLine($"You smash the {name}. What a mess.");
		else if (durability < 0)
    	   	Console.WriteLine($"The {name} is already broken.");
	}
}
/// <summary>
/// key class
/// </summary>
class Key : Base, ICollectable
{

	public bool isCollected {get; set;}
	/// <summary>
	/// key constructor
	/// </summary>
	/// <param name="name">name</param>
	/// <param name="isCollected">collected?</param>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}
	/// <summary>
	/// collect method
	/// </summary>
	public void Collect()
	{
		if (!isCollected)
		{
			Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
		}
		else
		{
			Console.WriteLine($"You have already picked up the {name}.");
		}
	}
}
/// <summary>
/// class roomobjescts
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// execute methods depending on what interface that item implements
    /// </summary>
    /// <param name="roomObjects">list of objects</param>
    /// <param name="type">types</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
	{
        foreach(var obj in roomObjects)
		{
            switch(type.ToString())
			{
                case "IInteractive":
                    if (obj is IInteractive)
					{
                        IInteractive instance = (IInteractive)obj;
                        instance.Interact();
                    }
                    break;
                case "IBreakable":
                    if (obj is IBreakable){
                        IBreakable instance = (IBreakable)obj;
                        instance.Break();
                    }
                    break;
                case "ICollectable":
                    if (obj is ICollectable){
                        ICollectable instance = (ICollectable)obj;
                        instance.Collect();
                    }
                    break;
                default:
                    break;
            }
        }
    
    }
}