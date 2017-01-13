using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercício 03] --> Tempo total das voltas ao Kartódromo.
namespace M02_P31_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo_volta, acumulado=0;
            Console.Write("Quantas voltas teve a corrida? ");
            int voltas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=voltas; i++)
            {
                Console.Write("Quanto tempo demorou na {0} volta? ", i);
                tempo_volta = Convert.ToInt32(Console.ReadLine());
                acumulado += tempo_volta;
            }
            Console.WriteLine("O tempo total foi: {0:f2} minutos",acumulado/60);
        }
    }
}
