using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            int[] arr = new int[9];
            int[] cp_arr = new int[9];
            for(int i=0;i<9;i++)
            {
                int value = int.Parse(Console.ReadLine());
                arr[i] = value;
                cp_arr[i] = value;
            }
            
            Array.Sort(arr);
            int max_value = arr[8];
            for(int i=0;i<9;i++)
            {
                if(cp_arr[i] == max_value)
                {
                    Console.WriteLine(max_value);
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}

