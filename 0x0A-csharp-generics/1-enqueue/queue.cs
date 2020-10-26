using System;
/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
	/// <summary>
	/// head node
	/// </summary>
	public Node head = null;
	/// <summary>
	/// tail node
	/// </summary>
	public Node tail = null;

	private int count = 0;

	/// <summary>
	/// check type of type passed in
	/// </summary>
	/// <returns>type in string format</returns>
	public string CheckType()
	{
		return(typeof(T).ToString());
	}
	/// <summary>
	/// adds node to queue
	/// </summary>
	/// <param name="Value">value of node</param>
	public void Enqueue(T Value)
	{
		Node passed = new Node(Value);
		if (head == null && tail == null)
		{
			head = passed;
			tail = passed;
		}
		else
		{
			tail.next = passed;
			tail = passed;
		}
		count += 1;
	}
	/// <summary>
	/// class Node
	/// </summary>
	public class Node
	{
		/// <summary>
		/// value passed in
		/// </summary>
		/// <returns></returns>
		public T value = default(T);
		/// <summary>
		/// next node set to null
		/// </summary>
		public Node next = null;
		/// <summary>
		/// constructor for Node 
		/// </summary>
		/// <param name="t">type value passed in</param>
		public Node (T t)
		{
			value = t;
		}
	}
	/// <summary>
	/// method to get count of queue
	/// </summary>
	/// <returns>int count</returns>
	public int Count()
	{
		return(count);
	}
}