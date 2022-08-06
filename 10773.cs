using System;
using System.Text;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new Stack<int>();
            int size = int.Parse(Console.ReadLine());
            for(int i=0;i<size;i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(input == 0)
                {
                    info.Pop();
                }
                else
                {
                    info.Push(input);
                }
            }
            int ans = 0;
            size = info.Count;
            for(int i=0;i<size;i++)
            {
                ans += info.Pop();
                
            }
            Console.WriteLine(ans);
        }
    }
}
