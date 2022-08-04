using System;
using System.Text; // 이번 코드는 이것을 쓰는 것이 핵심입니다.

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder number = new StringBuilder(); // 여기 number라는 변수안에 전부 담아서 처리합니다.cin.sync_with_stdio(false)와 같은 느낌
            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split();
                // Console.WriteLine("{0}", int.Parse(info[0]) + int.Parse(info[1]));
                int ans = int.Parse(info[0]) + int.Parse(info[1]);
                number.Append(ans); // 데이터의 타입에 상관없이 전부 넣을 수 있습니다. 파이썬 리스트 같은 느낌입니다. 앞으로 출력해야할 일이 있을 때는 이런 내용을 쓰면 좋을 것으로 보입니다.
                number.Append("\n");
            }
            Console.WriteLine(number.ToString());
        }   
    }
}

