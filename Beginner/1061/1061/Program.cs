using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, k, l, m, n, p, q, r, s, t, u, v;
            int []h = new int[5];

            string aa,bb,ab,ac,ba,ca;

            string[] tokensAA = Console.ReadLine().Split();
            aa=(tokensAA[0]);
            i = int.Parse(tokensAA[1]);

            string[] tokens = Console.ReadLine().Split();

            j = int.Parse(tokens[0]);
            ab = (tokens[1]);
            k = int.Parse(tokens[2]);
            ac = (tokens[3]);
            l = int.Parse(tokens[4]);

            string[] tokensBB = Console.ReadLine().Split();
            bb = (tokensBB[0]);
            p = int.Parse(tokensBB[1]);


            string[] tokens1 = Console.ReadLine().Split();
            q = int.Parse(tokens1[0]);
            ba = (tokens1[1]);
            r = int.Parse(tokens1[2]);
            ca = (tokens1[3]);
            s = int.Parse(tokens1[4]);
            

            m = 60 - l + s;
            n = (60 - k - 1 + r) * 60;
            t = (24 - 1 - j + q) * 3600;
            u = (p - i - 1) * 86400;
            v = m + n + t + u;

            h[0] = v / 86400;
            Console.WriteLine("{0} dia(s)", h[0]);

            h[0] = v % 86400;
            h[1] = h[0] / 3600;
            Console.WriteLine("{0} hora(s)", h[1]);

            h[1] = h[0] % 3600;
            h[2] = h[1] / 60;
            Console.WriteLine("{0} minuto(s)", h[2]);

            h[2] = h[1] % 60;
            Console.WriteLine("{0} segundo(s)", h[2]);

            Console.ReadLine();
        }
    }
}
