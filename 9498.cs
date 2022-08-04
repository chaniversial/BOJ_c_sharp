using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();
            int value = int.Parse(score);
            if((value>=90)&&(value<=100))
            {
                Console.WriteLine("A");
            }
            else if((value>=80)&&(value<=89))
            {
                Console.WriteLine("B");
            }
            else if((value>=70)&&(value<=79))
            {
                Console.WriteLine("C");
            }
            else if((value>=60)&&(value<=69))
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}

