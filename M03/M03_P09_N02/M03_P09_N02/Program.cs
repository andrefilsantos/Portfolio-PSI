using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P09_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(data_pascoa(ano, 0, 0, 0));
        }

        static string data_pascoa(int ano, int p, int pp, int ppp)
        {
            string data = "";
            int a, b, c, d, e, m = 0, n = 0;
            if ((ano >= 1582) && (ano <= 1699))
            {
                m = 22;
                n = 2;
            }
            if ((ano >= 1700) && (ano <= 1799))
            {
                m = 23;
                n = 3;
            }
            if ((ano >= 1800) && (ano <= 1899))
            {
                m = 23;
                n = 4;
            }
            if ((ano >= 1900) && (ano <= 1999))
            {
                m = 24;
                n = 5;
            }
            if ((ano >= 2000) && (ano <= 2099))
            {
                m = 24;
                n = 5;
            }
            if ((ano >= 2100) && (ano <= 2199))
            {
                m = 24;
                n = 6;
            }
            if ((ano >= 2200) && (ano <= 2299))
            {
                m = 25;
                n = 0;
            }
            if ((ano >= 2300) && (ano <= 2399))
            {
                m = 26;
                n = 1;
            }
            if ((ano >= 2400) && (ano <= 2499))
            {
                m = 25;
                n = 1;
            }
            a = ano % 19;
            b = ano % 4;
            c = ano % 7;
            d = (19 * a + m) % 30;
            e = (2 * b + 4 * c + 6 * d + n) % 7;
            p = 22 + d + e;
            if (p <= 31)
            {
                data = ("A páscoa será no dia " + p + " de Março.");
                    return data;
            }
            else
            {
                pp = d + e - 9;
                if (pp > 25)
                {
                    ppp = pp - 7;
                    data = ("A páscoa será no dia " + ppp + " de Abril.");
                    return data;
                }
                else
                {
                    data = "A páscoa será no dia " + pp + " de Abril.";
                    return data;
                }
            }
        }
    }
}