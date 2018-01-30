using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);

           int x = (a + b + Math.Abs(a - b)) / 2;
           int y = (x + c + Math.Abs(x - c)) / 2;

            Console.WriteLine("{0} eh o maior", y);
            Console.ReadLine();
        }

    }
}
