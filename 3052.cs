using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ans = new StringBuilder();
            bool[] visited = new bool[42];
            for (int i = 0; i < 42; i++)
                visited[i] = false;
            for(int i=0;i<10;i++)
            {
                int value = int.Parse(Console.ReadLine());
                int index = value % 42;
                visited[index] = true;
            }
            int cnt = 0;
            for (int i = 0; i < 42; i++)
                if (visited[i])
                    cnt++;
            ans.Append(cnt);
            Console.WriteLine(cnt);
        }
    }
}
