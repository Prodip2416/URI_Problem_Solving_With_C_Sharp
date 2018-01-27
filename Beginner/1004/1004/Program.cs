using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());

            result = FirstNumber * SecondNumber;

            Console.WriteLine("PROD = {0}", result);

            Console.ReadLine();
        }
    }
}
