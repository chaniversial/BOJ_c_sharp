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
            StringBuilder ans = new StringBuilder();
            int size = int.Parse(Console.ReadLine());
            for(int i=0;i<size;i++)
            {
                string[] order = Console.ReadLine().Split();
                if(order[0]=="push")
                {
                    info.Push(int.Parse(order[1]));
                    continue;
                }
                else if(order[0] == "pop")
                {
                    if(info.Count == 0)
                    {
                        ans.Append(-1);
                        //ans.Append("\n");
                    }
                    else
                    {
                        //ans.Append(info.Peek());
                        //ans.Append("\n");
                        ans.Append(info.Pop());
                    }
                }
                else if(order[0] == "size")
                {
                    ans.Append(info.Count);
                }
                else if(order[0] == "empty")
                {
                    if (info.Count == 0)
                        ans.Append(1);
                    else
                        ans.Append(0);
                }
                else if(order[0] == "top")
                {
                    if (info.Count == 0)
                        ans.Append(-1);
                    else
                        ans.Append(info.Peek());
                }
                ans.Append("\n");

            }
            Console.WriteLine(ans);

        }
    }
}
