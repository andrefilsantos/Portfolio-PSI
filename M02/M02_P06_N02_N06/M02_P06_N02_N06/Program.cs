using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 05] --> Carteiros.
namespace M02_P06_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_porta, resto;

            Console.Write("Qual é o número da porta? ");
            num_porta = Convert.ToInt16(Console.ReadLine());
            resto = num_porta % 2;
            if (resto == 0)
            {
                Console.WriteLine("O Zé Navarro deve entragar esta carta");
            }
            else
            {
                Console.WriteLine("O Pimpão Navarro deve entregar esta carta");
            }
        }
    }
}
