using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P04_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            char operacao = '0';
            Console.Write("numero 1: ");
            int numero_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 2: ");
            int numero_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a operação? ");
            operacao = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(resultado(numero_1, numero_2, operacao));
        }

        static int resultado(int numero1, int numero2, char operacao)
        {
            switch (operacao)
            {
                case '+':
                    Console.Clear();
                    Console.WriteLine(soma(numero_1, numero_2));
                    break;
                case '-':
                    Console.Clear();
                    Console.WriteLine(subtracao(numero_1, numero_2));
                    break;
                case '*':
                    Console.Clear();
                    Console.WriteLine(multiplicacao(numero_1, numero_2));
                    break;
                case '/':
                    Console.Clear();
                    Console.WriteLine(divisao(numero_1, numero_2));
                    break;
                default:
                    Console.WriteLine("Operador Inválido.\nSó pode usar o '+', o '-', o '*' e o '/'.");
                    break;
            }
        }
        
    }
}
