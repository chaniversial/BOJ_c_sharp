using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = 0;
            int value = 1;
            for (int i = 0; i < 3; i++)
                value = value * int.Parse(Console.ReadLine());
            while(value > 0)
            {
                int check = value % 10;
                arr[check]++;
                value = value / 10;
            }
            for(int i=0;i<10;i++)
            {
                ans.Append(arr[i]);
                ans.Append("\n");
            }
            Console.WriteLine(ans);
        }
    }
}
