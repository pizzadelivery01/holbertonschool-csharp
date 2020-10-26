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
	/// removes head node
	/// </summary>
	/// <returns>value of node or msg</returns>
	public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node NedStark = head;
        head = NedStark.next;
        count -= 1;
        return (NedStark.value);
    }
	/// <summary>
	/// gets value of head
	/// </summary>
	/// <returns>value or msg</returns>
	public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }
	/// <summary>
	/// prints queue
	/// </summary>
	public void Print()
    {
        Node runner = head;
        if (runner == null)
            Console.WriteLine("Queue is empty");
        while (runner != null)
        {
            Console.WriteLine(runner.value.ToString());
            runner = runner.next;
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
	/// <summary>
	/// prints queue of strings or char
	/// </summary>
	/// <returns>string</returns>
	public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
        string newString = "";
        Node runner = head;
        while (runner != null)
        {
            newString = newString + runner.value.ToString();
            if (runner != tail && typeof(T) == typeof(string))
                newString += " ";
            runner = runner.next;
        }
        return (newString);
    }
}