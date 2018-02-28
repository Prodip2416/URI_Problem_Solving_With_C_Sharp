using System;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int i = 1;
            for(i=1 ; i <= X; i=i+2)
            {  
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
