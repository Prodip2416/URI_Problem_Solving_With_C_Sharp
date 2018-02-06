using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double UserIpnut = double.Parse(Console.ReadLine());

            if(UserIpnut >=0.00000 && UserIpnut <= 25.00000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(UserIpnut >25.00000 && UserIpnut <= 50.00000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(UserIpnut>50.00000 && UserIpnut <= 75.00000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(UserIpnut>75.00000 && UserIpnut <= 100.00000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.ReadLine();
        }
    }
}
