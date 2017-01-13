using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 10] --> Saber se um ano é bissexto. 
namespace M02_P09_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.Write("Qual é o ano?: ");
            ano = Convert.ToInt32(Console.ReadLine());
            if ((ano % 4 == 0) && (ano % 100 != 0))
            {
                Console.WriteLine("O ano é bissexto.\n");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto.\n");
            }
        }
    }
}
