using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P50_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a altura do retângulo? ");
            byte altura = Convert.ToByte(Console.ReadLine());
            Console.Write("Qual é a largura do retângulo? ");
            byte largura = Convert.ToByte(Console.ReadLine());
            //Primeira Linha
            for (int i = (largura-largura+1); i <= largura; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            for (int a = 0; a < altura-2; a++)
            {
                Console.Write("x");
                if ((a != 0) || (a != altura))
                {
                    Console.WriteLine();
                }
                /*for (int i = (largura - largura + 1); i <= largura; i++)
                {
                    Console.Write(" ");
                }*/

            }
            for (int i = (largura - largura + 1); i <= largura; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }
    }
}
