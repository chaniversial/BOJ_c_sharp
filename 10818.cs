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
            string[] info = Console.ReadLine().Split();
            int[] array = new int[num];
            for(int i=0;i<num; i++)
            {
                array[i] = int.Parse(info[i]);
            }
            Array.Sort(array);
            ans.Append(array[0]);
            ans.Append(" ");
            ans.Append(array[num - 1]);
            Console.WriteLine(ans);
        }
    }
}

