using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P21_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor Variavel 1: ");
            int variavel_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor Variavel 2: ");
            int variavel_2 = Convert.ToInt32(Console.ReadLine());
            troca(variavel_1, variavel_2);
        }
        static void troca(int variavel_1, int variavel_2)
        {
            int variavel_auxiliar = variavel_1;
            variavel_1 = variavel_2;
            variavel_2 = variavel_auxiliar;
            Console.WriteLine("O valor da primeira variavel é agora {0} e da segunda {0}.", variavel_1, variavel_2);

        }
    }
}
