using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;
            while (true)
            { 
                Start:
                int a = Convert.ToInt32(Console.ReadLine());

                if (a > 0)
                {
                    if (a == 1)
                    {
                        Alcool++;
                    }
                    else if(a==2)
                    {
                        Gasolina++;
                    }
                    else if (a == 3)
                    {
                        Diesel++;
                    }
                    else if (a == 4)
                    {
                        break;
                    }
                    else
                    {
                        goto Start;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}",Alcool);
            Console.WriteLine("Gasolina: {0}", Gasolina);
            Console.WriteLine("Diesel: {0}", Diesel);
        }
    }
}
