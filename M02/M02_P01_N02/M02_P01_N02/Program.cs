using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
                Console.Write("Qual é a tua idade? ");
                idade= Convert.ToByte(Console.ReadLine());
                if ((idade >= 14) && (idade <= 20))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Podes entrar no curso de GPSI!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Infelizmente, não podes entrar no curso de GPSI, ");
                    if (idade > 20)
                    {
                        Console.WriteLine("porque tens mais de 20 anos.");
                    }
                    else
                    {
                        Console.WriteLine("porque tens menos de 14 anos.");
                    }
                }
                Console.ReadKey();
        }
    }
}
