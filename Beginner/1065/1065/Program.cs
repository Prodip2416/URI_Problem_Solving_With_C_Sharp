using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {

           int a, b = 0;
            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a%2==0)
                {
                    b++;
                }
            }
            Console.WriteLine("{0} valores pares", b);

            Console.ReadLine();
        }
    }
}
