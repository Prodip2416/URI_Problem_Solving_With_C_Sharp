using System;
namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int i = 1;

            for (i = 1; i <= 6; i++)
            {
                if (X % 2 == 0)
                    X++;
                Console.WriteLine(X);
                X += 2;
            }
            Console.ReadLine();
        }
    }
}
