using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //string[] token = Console.ReadLine().Split(' ');
                int userPass = Convert.ToInt32(Console.ReadLine());

                if (userPass == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
