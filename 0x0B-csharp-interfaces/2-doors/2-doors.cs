using System;
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
	private string name {get; set;}
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
	/// <param name="doorname">name</param>
	public Door(string doorname = "Door")
	{
		name = doorname;
	}
	/// <summary>
	/// interact method
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}