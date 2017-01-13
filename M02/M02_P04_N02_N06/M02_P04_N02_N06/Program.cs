using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 02] --> Operadoras de Supermercado.
namespace M02_P04_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, valor_recebido, troco;

            Console.Write("Qual o valor total? ");
            total = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor recebido? ");
            valor_recebido = Convert.ToDouble(Console.ReadLine());
            troco = valor_recebido - total;
            if (valor_recebido < total)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O valor não é suficiente.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O troco é de: {0} Euros", troco);
            }
            Console.ReadKey();
        }
    }
}
