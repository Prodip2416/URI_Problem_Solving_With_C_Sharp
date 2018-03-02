using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, input, max = 0, position=0;
            for (i = 1; i <= 100; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (max < input)
                {
                    max = input;
                    position = i;
                }
            }
            Console.WriteLine("{0}\n{1}", max, position);

            Console.ReadLine();
        }
    }
}
