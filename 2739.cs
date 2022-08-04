using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value = int.Parse(input);
            for (int i = 1; i <= 9; i++)
                Console.WriteLine("{0} * {1} = {2}", value, i, value * i);
        }
    }
}

