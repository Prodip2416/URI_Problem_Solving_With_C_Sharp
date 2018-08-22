using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1865
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = "";
            string str1 ="";
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                str = tokens[0];
               str1 = tokens[1];

                if (str[0] == 'T' && str[1] == 'h' && str[2] == 'o' && str[3] == 'r')
                    Console.WriteLine("Y");
                else
                    Console.WriteLine("N");
            }
           
        }
    }
}
