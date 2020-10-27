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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability {get; set;}
	public bool isCollected {get; set;}
	public string name {get; set;}
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
}