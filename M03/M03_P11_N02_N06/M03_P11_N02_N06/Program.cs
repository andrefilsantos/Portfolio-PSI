using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P11_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Número:  ");
            n = Convert.ToInt32(Console.ReadLine());
            divisor(n);
        }

        static void divisor(int n)
        {
            int i = 1;
            int divisor = 0;
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisor = i;
                }
            }
            Console.WriteLine(divisor);
        }
    }
}
