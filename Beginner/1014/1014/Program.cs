using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double avarageConsumption = X / Y;

            Console.WriteLine("{0:0.000} km/l", avarageConsumption);
            Console.ReadLine();
        }
    }
}
