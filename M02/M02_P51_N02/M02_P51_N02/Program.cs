using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P51_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, resultado = 1;
            Console.Write("Introduza o número: ");
            int numero_decimal = Convert.ToInt32(Console.ReadLine());
            do
            {
                resultado = numero_decimal / 2;
                resto = numero_decimal % 2;
            } while (resultado != 0);

            Console.WriteLine(resto);
            Console.WriteLine(resultado);
        }
    }
}
