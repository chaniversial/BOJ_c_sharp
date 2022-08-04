using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            for(int i=0;i<int.Parse(num);i++)
            {
                string[] input = Console.ReadLine().Split();
                int first = int.Parse(input[0]);
                int second = int.Parse(input[1]);
                Console.WriteLine("{0}", first + second);
            }
        }
    }
}

