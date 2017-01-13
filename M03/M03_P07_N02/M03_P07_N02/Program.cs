using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P07_N02
{
    class Program
    {
        static void Main(string[] args)
        {

            double nova_capital;
            Console.Write("Capital: ");
            double capital = Convert.ToInt32(Console.ReadLine());
            Console.Write("Taxa de Juro: ");
            double taxa_juro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Duração: ");
            byte duracao = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= duracao; i++)
            {
                Console.WriteLine("Ao fim do {0}º ano, terá {1:f2} euros.", i, novacapital(taxa_juro, ref capital));
            }
        }
        static double novacapital(double taxa_juro, ref double capital)
        {
            capital += (capital * (taxa_juro / 100));
            return capital;
        }
    }
}