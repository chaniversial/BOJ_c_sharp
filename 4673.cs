using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            solution();   
        }
        static void solution()
        {
            StringBuilder ans = new StringBuilder();
            bool[] arr = new bool[10001];
            
            for(int i=0;i<10001;i++)
            {
                int a = i / 10000;a = a % 10;
                int b = i / 1000; b = b % 10;
                int c = i / 100;c = c % 10;
                int d = i / 10;d = d % 10;
                int e = i % 10;
                int index = i + a + b + c + d + e;

                if((index > 0)&&(index < 10001))
                    arr[index] = true;
            }
            for (int i = 1; i < 10001; i++)
                if (!arr[i])
                {
                    ans.Append(i);
                    ans.Append("\n");
                }
            Console.WriteLine(ans);
        }
    }
}
