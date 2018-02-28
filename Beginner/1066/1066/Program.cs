using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0,c=0,d=0,e=0;
            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > 0) d++;
                else if(a<0) e++;
                if (a % 2 == 0) b++;
                else  c++;
            }
            Console.WriteLine("{0} valor(es) par(es)", b);
            Console.WriteLine("{0} valor(es) impar(es)", c);
            Console.WriteLine("{0} valor(es) positivo(s)", d);
            Console.WriteLine("{0} valor(es) negativo(s)", e);

            Console.ReadLine();
        }
    }
}
