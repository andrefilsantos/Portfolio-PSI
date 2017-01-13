using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P13_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Qual é o numero?  ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (divisores_de_n(n))
            {
                case true: Console.WriteLine("Número Perfeito");
                    break;
                case false: Console.WriteLine("Número não perfeito");
                    break;
            }
        }
        static bool divisores_de_n(int n)
        {
            int soma = 0;
            bool vf;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    soma += i;
                }
            }

            if (soma == n)
            {
                vf = true;
            }

            else
            {
                vf = false;
            }
            return vf;
        }

    }
}
