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
                for(int j=num - i - 1;j>0;j--)
                {
                    ans.Append(" ");
                }
                for(int k=0;k<=i;k++)
                {
                    ans.Append("*");
                }
                ans.Append("\n");
            }
            Console.WriteLine(ans);
        }
    }
}

