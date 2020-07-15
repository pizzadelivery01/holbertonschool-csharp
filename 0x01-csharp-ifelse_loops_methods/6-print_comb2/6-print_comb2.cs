using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 89; i++)
            {
                string number = i.ToString("00");
                if(i != 89)
                {
                    if(number[0] - '0' < number[1] - '0')
                    {
                        Console.Write("{0:00}, ", i);
                    }
                }
                else
                {
                    Console.WriteLine("{0:00}", i);
                }
            }
        }
    }
}
