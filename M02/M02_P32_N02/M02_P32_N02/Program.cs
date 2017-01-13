using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 32 [Desafio extra-aula] --> fazer quadrado com altura e largura definida pelo utilizador.
namespace M02_P32_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a altura do retângulo? ");
            byte altura = Convert.ToByte(Console.ReadLine());
            Console.Write("Qual é a largura do retângulo? ");
            byte largura = Convert.ToByte(Console.ReadLine());
            Console.Write("Com que letra quer que apareça o retangulo? ");
            char letra = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < altura; i++)
            {
                if ((i == 0) || (i == (altura - 1)))
                {
                    for (int j = 0; j < largura; j++)
                    {
                        Console.Write(letra);
                    }
                    Console.WriteLine();
                }
                else
                {
                    if ((!(i == 0) || (i == (altura - 1))))
                    {
                        for (int j = 0; j < largura; j++)
                        {
                            if ((j == 0) || (j == largura - 1))
                            {
                                Console.Write(letra);
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
