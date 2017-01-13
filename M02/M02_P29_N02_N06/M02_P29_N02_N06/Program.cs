 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercício 01] --> Soma dos números de 1 a 100.
namespace M02_P29_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulado = 0;
            int resultado;
            for (int i = 1; i <= 100; i++)
            {
                resultado = acumulado + i;
                Console.WriteLine("{0} + {1} = {2}", i, acumulado, resultado);
                acumulado = resultado;
            }
        }
    }
}
