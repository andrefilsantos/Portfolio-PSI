using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 08] --> Operadoras de Supermercado.
namespace M02_P07_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia_percorrida, ajudas_custo;
            int cilindrada_motor, combustivel;

            Console.Write("Qual é o combustível do seu automovel? \n[1= gasolina; 2= gasóleo] ");
            combustivel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual é a distância percorrida (km)? ");
            distancia_percorrida = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é a cilindrada do motor? ");
            cilindrada_motor = Convert.ToInt32(Console.ReadLine());
            if (combustivel == 1)
            {
                if (cilindrada_motor < 2000)
                {
                    ajudas_custo = (distancia_percorrida * 0.12);
                    Console.WriteLine("\nA sua ajuda de custo é {0} euros", ajudas_custo);
                }
                else
                {
                    ajudas_custo = ((distancia_percorrida * 0.25) + (distancia_percorrida * 0.05));
                    Console.WriteLine("\nA sua ajuda de custo é {0} euros", ajudas_custo);
                }
            }
            else //(combustivel==2)
            {
                if (cilindrada_motor > 2000)
                {
                    ajudas_custo = (distancia_percorrida * 0.12);
                    Console.WriteLine("\nA sua ajuda de custo é {0} euros", ajudas_custo);
                }
                else
                {
                    ajudas_custo = ((distancia_percorrida * 0.25) + (distancia_percorrida * 0.03));
                    Console.WriteLine("\nA sua ajuda de custo é {0} euros", ajudas_custo);
                }
            }
        }
    }
}
