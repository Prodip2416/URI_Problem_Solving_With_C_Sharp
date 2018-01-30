using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            int[] list = new int[7] { 100, 50, 20, 10, 5, 2, 1 };
            int []result = new int[7];
            int a;
            Console.WriteLine("{0}", userInput);

            for(int i = 0; i < 7; i++)
            {
                result[i] = userInput / list[i];
                Console.WriteLine("{0} nota(s) de R$ {1},00", result[i], list[i]);
                a = userInput - (result[i] * list[i]);
                userInput = a;
            }

            Console.ReadLine();
        }
    }
}
