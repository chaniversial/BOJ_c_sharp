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
            for(int i=num;i>=1;i--)
            {
                ans.Append(i);
                ans.Append("\n");
            }
            Console.WriteLine(ans);
        }   
    }
}

