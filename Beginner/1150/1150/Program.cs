using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)

        {
            int result = 0;
            int count = 0;
            int X = Convert.ToInt32(Console.ReadLine());
            int Z = Convert.ToInt32(Console.ReadLine());
            while (Z <= X)
            {
                Z = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = X; i < Z; i++)
            {
                result += i;
                count++;
                if (result > Z) break;
            }
            Console.WriteLine(count);
        }
    }
}
