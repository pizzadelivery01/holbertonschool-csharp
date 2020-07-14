using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string triple = string.Join("", Enumeralbe.Repeat(str,3));
        Console.WriteLine({0}, triple);
		Console.WriteLine({0}, str.Substring(0,9));
    }
}