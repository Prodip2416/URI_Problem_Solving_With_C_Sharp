using System;
namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split();
            int code1 = int.Parse(tokens1[0]);
            int product1 = int.Parse(tokens1[1]);
            double price1 = double.Parse(tokens1[2]);

            double FirstResult = product1 * price1;

            string[] tokens2 = Console.ReadLine().Split();
            int code2 = int.Parse(tokens2[0]);
            int product2 = int.Parse(tokens2[1]);
            double price2 = double.Parse(tokens2[2]);

            double SecondResult = product2 * price2;

            double FinalResult = FirstResult + SecondResult;

            Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", FinalResult);
            Console.ReadLine();

        }
    }
}
