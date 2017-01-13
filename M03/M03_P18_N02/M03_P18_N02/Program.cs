using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P18_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1º Número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2º Número: ");
            int m = Convert.ToInt32(Console.ReadLine());
            numeros_pares(n, m);
        }
        static void numeros_pares(int n, int m)
        {
            if (m < n)
            {
                Console.WriteLine("Valores Inválidos!");
            }
            else
            {
                Console.Write("Os números pares entre {0} e {1} são: ", n, m);
                for (int i = n; i <= m; i += 2)
                {
                    Console.Write(i);
                    if (i != m)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine(".");
        }
    }
}
