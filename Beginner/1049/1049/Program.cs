using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            if(a == "vertebrado")
            {
                if(b == "ave")
                {
                    if(c== "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                    else if(c== "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                }
                else if (b == "mamifero")
                {
                    if (c == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (c == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            if (a == "invertebrado")
            {
                if (b == "inseto")
                {
                    if (c == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (c == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (b == "anelideo")
                {
                    if (c == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (c == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
