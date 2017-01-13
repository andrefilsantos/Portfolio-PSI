using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P39_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            Console.Write("Fatorial do número ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("O fatorial de 0 é 1.");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado = i * (i+1);
                }
            }
            Console.WriteLine("O fatorial de {0} é {1}", numero, resultado);
        }
    }
}
