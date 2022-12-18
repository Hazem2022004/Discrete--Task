using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter N1 ,N2");
            int N1 =int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            if (N1 == 0)
                N1++;
            int n, i, sum;
            for (n = N1; n <= N2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.ReadLine();
        }
    }
}
