using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int Year, Day, Month;
            int UserInput = int.Parse(Console.ReadLine());

           Year = UserInput / 365;
           Month = (UserInput % 365) / 30;
           Day = (UserInput %365) % 30 ;

            Console.WriteLine("{0} ano(s)", Year);
            Console.WriteLine("{0} mes(es)", Month);
            Console.WriteLine("{0} dia(s)", Day);
            Console.ReadLine();
        }
    }
}
