using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = Console.ReadLine();
            double total = 0;
            double salary = Convert.ToDouble(Console.ReadLine());
            double sold = Convert.ToDouble(Console.ReadLine());

            total = salary + (sold * 0.15);
            Console.WriteLine("TOTAL = R$ {0:0.00}", total);
            Console.ReadLine(); 
        }
    }
}
