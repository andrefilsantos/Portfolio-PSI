using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 02 [Exercício 01] --> Calculadora rudimentar. 
namespace M02_P13_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            char operador;

            Console.WriteLine("Olá! Apresentamos-te a nossa versão simplificada de uma calculadora. \nDe seguida, deves inserir o 1º número, seguido da operação que queres efetuar e, depois, o segundo número. \nBons Cálculos.");
            Console.Write("> ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" ");
            operador = Convert.ToChar(Console.ReadLine());
            Console.Write("  ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            switch (operador)
            {
                case '+': resultado = numero1 + numero2;
                    Console.WriteLine("______");
                    Console.WriteLine("= {0} \n", resultado);
                    break;
                case '-': resultado = numero1 - numero2;
                    Console.WriteLine("______");
                    Console.WriteLine("= {0} \n", resultado);
                    break;
                case '*': resultado = numero1 * numero2;
                    Console.WriteLine("______");
                    Console.WriteLine("= {0} \n", resultado);
                    break;
                case '/': resultado = numero1 / numero2;
                    if (numero2 == 0)
                    {
                        Console.WriteLine("2º número inválido.");
                    }
                    else
                    {
                        Console.WriteLine("______");
                        Console.WriteLine("= {0} \n", resultado);
                    }
                    break;
                case '^': resultado = Math.Pow(numero1, numero2);
                    Console.WriteLine("______");
                    Console.WriteLine("= {0} \n", resultado);
                    break;
                default: Console.WriteLine("Valor Inválido");
                    break;
            }


        }
    }
}
