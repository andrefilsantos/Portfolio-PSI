using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercicio 11] --> Números primos
namespace M03_P20_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.Write("Número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (seraprimo(numero))
            {
                case true: Console.WriteLine("É um número primo.");
                    break;
                default: Console.WriteLine("É um número primo.");
                    break;
            }
        }
        static bool seraprimo(int numero)
        {
            bool resposta = false;
            for (int i = 2; i < numero; i++)
            {
                int resto = numero % i;
                if (resto == 0)
                {
                    resposta = false;
                    i = numero + 1;
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }

        }
    }
}
