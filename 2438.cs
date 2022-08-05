using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder(); // 백준 같은 경우 출력 속도가 중요하니 다음의 값에 계속 정답값을 저장하고 한번에 출력하자.
            int num = int.Parse(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    ans.Append("*");
                }
                ans.Append("\n");
            }
            Console.WriteLine(ans);
        }
    }
}

