using System;
/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
	/// <summary>
	/// check type of type passed in
	/// </summary>
	/// <returns>type in string format</returns>
	public string CheckType()
	{
		return(typeof(T).ToString());
	}
}