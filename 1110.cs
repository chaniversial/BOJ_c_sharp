using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            int input = int.Parse(Console.ReadLine());
            int real = input;
            int cnt = 1;
            while(true)
            {
                int first = input / 10;
                int second = input % 10;
                int new_second = (first + second) % 10;
                int new_num = second * 10 + new_second;
                if (new_num != real)
                {
                    cnt++;
                    input = new_num;
                }
                else
                {
                    Console.WriteLine(cnt);
                    break;
                }
            }

        }
    }
}

