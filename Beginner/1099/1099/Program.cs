using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                string[] tokens_x1 = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x1[0]);
                int y = Convert.ToInt32(tokens_x1[1]);

                if (x > y)
                {
                    count = 0;
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j%2 == 0)
                        {

                        }
                        else
                        {
                            count += j;
                        }
                    }
                }
                else

                    count = 0;
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 == 0)
                        {

                        }
                        else
                        {
                            count += j;
                        }
                    }
                Console.WriteLine(count);
            }
               
           
            Console.ReadLine();
        }
    }
}
