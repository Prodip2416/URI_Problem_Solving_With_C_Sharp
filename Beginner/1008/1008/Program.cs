using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());

            double amount =Convert.ToDouble(Console.ReadLine());
            double salary = 0F;
            salary = hour * amount;

            Console.WriteLine("NUMBER = {0}", NUMBER);
            Console.WriteLine("SALARY = U$ {0:0.00}", salary);

            Console.ReadLine();

        }
    }
}
