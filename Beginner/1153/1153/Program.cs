using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            if (N > 0 && N < 13)
            {
                for (int i = N; i > 0; i--)
                {
                    result =result* i;
                }

                Console.WriteLine(result);
            }
        }
    }
}
