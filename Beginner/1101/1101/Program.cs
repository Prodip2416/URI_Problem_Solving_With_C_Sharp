using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                string[] token = Console.ReadLine().Split(' ');
                int M = Convert.ToInt32(token[0]);
                int N = Convert.ToInt32(token[1]);

                int sum = 0,j=0;
                if (M <= 0 || N <= 0)
                {
                    break;
                }
                else
                {
                    if (M > N)
                    {
                        sum = 0;
                        for (j = N; j <= M; j++)
                        {

                            Console.Write(j + " ");
                            sum += j;
                        }
                        Console.Write("Sum={0}", sum);
                        Console.WriteLine();
                    }
                    else if (N > M)
                    {
                        sum = 0;
                        for (j = M; j <= N; j++)
                        {

                            Console.Write(j + " ");
                            sum += j;
                        }
                        Console.Write("Sum={0}", sum);
                        Console.WriteLine();
                    }
                }
                
            }
           
           
        }
    }
}
