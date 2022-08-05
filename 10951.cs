using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            while(true)
            {
                string info = Console.ReadLine();
                if (info == "")
                    break;
                string[] data = info.Split();
                Console.WriteLine(int.Parse(data[0]) + int.Parse(data[1]));
            }

        }
    }
}

