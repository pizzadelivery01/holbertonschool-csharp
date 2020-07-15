using System;

class Program
{
    static void Main(string[] args)
    {
       for(int i=0; i <= 99; i++)
       {
           string hex = i.ToString("X");
           Console.WriteLine("{0} = 0x{1}", i, hex);
       }
    }
}