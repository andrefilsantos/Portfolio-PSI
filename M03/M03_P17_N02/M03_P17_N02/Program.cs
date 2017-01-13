using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Execicio 08] --> Múltiplos de um número
namespace M03_P17_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            multiplos(numero);
        }
        static void multiplos(int numero)
        {
            string multiplos_str = "Os múltiplos de " + numero + " são ";
            for (int i = 1; i <= 100; i += numero)
            {
                if ((i % numero) == 0)
                {
                    multiplos_str += i + ", ";
                }
            }
            Console.WriteLine(multiplos_str);
        }
    }
}
