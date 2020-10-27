using System;

public interface IInteractive
{
	void Interact();
}

public interface IBreakable
{
	int durability {get; set;}
	void Break();
}

public interface ICollectable
{
	bool isCollected {get; set;}

	void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability {get; set;}
	public bool isCollected {get; set;}
	public string name {get; set;}
	public void Interact()
	{
		
	}
	public void Collect()
	{

	}
}