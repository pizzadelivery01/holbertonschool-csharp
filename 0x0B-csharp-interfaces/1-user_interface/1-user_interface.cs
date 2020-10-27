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
/// Test Object
/// </summary>

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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	
	/// <summary>
	/// durability
	/// </summary>
	/// <value>int</value>
	public int durability {get; set;}
	/// <summary>
	/// collected
	/// </summary>
	/// <value></value>
	public bool isCollected {get; set;}
	/// <summary>
	/// interact
	/// </summary>
	public void Interact()
	{
		
	}
	/// <summary>
	/// collect
	/// </summary>
	public void Collect()
	{

	}
	public void Break()
	{

	}
}