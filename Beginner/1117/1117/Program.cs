using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double result = 0;

            while (true)
            {

               
              
                double finallResult = 0;
                double x = Convert.ToDouble(Console.ReadLine());

                if (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    count++;
                    result += x;
                    if (count == 2)
                    {
                        finallResult = result/2;
                        Console.WriteLine("media = {0:N2}", finallResult);
                        break;
                    }

                }

            }
        }
    }
}
