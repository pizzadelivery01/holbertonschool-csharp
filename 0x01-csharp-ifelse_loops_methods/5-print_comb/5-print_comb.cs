using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i =0; i <= 9; i++)
        {
            int first = i;
            for(int j = 0; j <= 9; j++)
            {
                int second = j;
                Console.Write("{0}{1}, ", first, second);
            }
        }
        Console.WriteLine("99");
    }
}
