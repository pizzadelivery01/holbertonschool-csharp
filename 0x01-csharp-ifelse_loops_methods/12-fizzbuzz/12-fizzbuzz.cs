using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        for (i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0)
                Console.Write("FizzBuzz");
            else if (i % 5 == 0) {
                Console.Write("Buzz");
            }
            else if (i % 3 == 0) {
                Console.Write("Fizz");
            }
            else
            {
                Console.Write(i);
            }
            if (i != 100) {
                Console.Write(" ");
            }
            else {
                Console.Write("\n");
            }
        }
    }
}