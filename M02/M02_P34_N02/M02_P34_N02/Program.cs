using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercicio 05] --> Sistema de aquecimento da escola.
namespace M02_P34_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte temperatura, temp_minima = 250, temp_maxima = 0;
            for (int i = 9; i <= 17; i++)
            {
                Console.Write("Qual foi a temperatura às {0} horas? ", i);
                temperatura = Convert.ToByte(Console.ReadLine());
                if (i == 9)
                {
                    temp_minima = temperatura;
                    temp_maxima = temperatura;
                }
                else
                {
                    if (temperatura > temp_maxima)
                        temp_maxima = temperatura;
                    if (temperatura < temp_minima)
                        temp_minima = temperatura;
                }
            }
            Console.WriteLine("Hoje, a temperatura máxima foi {0}ºC e a temperatura Mínima foi {1}ºC\nAssim, a amplitude térmica foi {2}", temp_maxima, temp_minima, temp_maxima - temp_minima);
        }
    }
}
