using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int count = 0;
            double avg = 0;
            while (true)
            {
                int N = Convert.ToInt32(Console.ReadLine());

                if (N < 0)
                {
                    break;
                }
                total += N;
                count++;

            }
            avg =(double) total/count;
            Console.WriteLine("{0:N2}",avg);
        }
    }
}
