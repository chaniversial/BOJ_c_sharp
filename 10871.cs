using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            string[] info = Console.ReadLine().Split();
            int first = int.Parse(info[1]);
            int second = int.Parse(info[0]);
            string[] data = Console.ReadLine().Split();
      
            for(int i=0;i<second; i++)
            {
                int check = int.Parse(data[i]);
                if (check < first)
                {
                    ans.Append(check);
                    ans.Append(" ");
                }
            }
            Console.WriteLine(ans);
        }
    }
}

