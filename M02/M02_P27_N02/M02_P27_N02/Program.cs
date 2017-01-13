using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 27 --> Descobrir a tecla mágica.
namespace M02_P27_N02
{
    class Program
    {
        static void Main(string[] args)
        {
           char tecla;
           byte tentativas=0;
            do
            {
                Console.Write("Descubra a tecla mágica: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                tecla = Convert.ToChar(Console.ReadLine());
                Console.ResetColor();
                tentativas ++;
                if (tentativas==10)
                {
                    Console.WriteLine("Gastou todas as tentativas disponiveis!");
                    goto Fim;
                }
            } while (tecla != '1');
            Console.WriteLine("Descobriu!! \nTentou {0} vezes.", tentativas);
            Fim: ;
        }
    }
}
