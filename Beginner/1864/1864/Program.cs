using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1864
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "life is not a problem to be solved".ToUpper();

            int n = Convert.ToInt32(Console.ReadLine());
            string str = "";
            if (n > 0 && n <= 34)
            {
                for (int i = 0; i < n; i++)
                {
                    str += myString[i];
                }
                Console.WriteLine(str);
            }
        }
    }
}
