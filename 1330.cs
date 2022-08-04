using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);
            if(first > second)
            {
                Console.WriteLine(">");
            }
            else if(first < second)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }

        }
    }
}

