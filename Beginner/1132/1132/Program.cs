using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            if (Y > X)
            {
                for (int i = X; i <= Y; i++)
                {
                    if (i%13 == 0)
                    {
                        continue;
                    }
                    sum += i;

                }
                Console.WriteLine(sum);
            }
            else if(X>Y)
            {
                for (int i = Y; i <= X; i++)
                {
                    if (i % 13 == 0)
                    {
                        continue;
                    }
                    sum += i;

                }
                Console.WriteLine(sum);
            }
        }
    }
}
