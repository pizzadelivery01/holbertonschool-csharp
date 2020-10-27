﻿using System;

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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{

}