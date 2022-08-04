using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            int num = int.Parse(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                ans.Append(i + 1);
                ans.Append("\n");
            }
            Console.WriteLine(ans);
        }   
    }
}

