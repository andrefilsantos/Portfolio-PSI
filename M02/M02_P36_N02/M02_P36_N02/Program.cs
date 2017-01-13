using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercicio 08] --> Transportadora com maximo de 100 kg
namespace M02_P36_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso_max = 1000;
            int acumulado=0, peso_mala, i=0;
            do
            {
                i++;
                Console.Write("Qual é o peso da {0}ª mala? ", i);
                peso_mala = Convert.ToInt32(Console.ReadLine());
                acumulado += peso_mala;
                if (acumulado > peso_max)
                {
                    Console.WriteLine("Com esta mala, o peso do transporte excede os {0} kg, pelo que esta já não pode ser transportada.", peso_max);
                    i--;
                }
            } while (acumulado < peso_max);
            Console.WriteLine("Nesta viagem, irá levar {0} malas, por isso, o lucro é de {1} Euros.", i, i*20);
        }
    }
}
