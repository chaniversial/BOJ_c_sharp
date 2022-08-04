using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int value = int.Parse(num);
            Console.WriteLine(solution(value));
        }   
        static int solution(int cnt)
        {
            if (cnt <= 1)
                return cnt;
            else
                return cnt + solution(cnt - 1);
        }
      
    }
}

