using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercício 02] --> Pagamento em grãos a um monge.
namespace M02_P30_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal graos=1;
            decimal resultado;

            for (int i = 1; i <= 64; i++)
            {
                resultado = graos * 2;
                Console.WriteLine("No {0} quadrado terá {1} grãos.", i, resultado);
                graos = resultado;
            }
        }
    }
}
