using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 26; i++)
        {
            if (i != 4 && i != 16)
            {
                Console.Write(Convert.ToChar(i + (int)'a'));
            }
        }
    }
}